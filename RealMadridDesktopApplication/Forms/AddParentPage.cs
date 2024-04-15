using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using Npgsql;
using RealMadridDesktopApplication.Modules;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RealMadridDesktopApplication.Forms
{
    public partial class AddParentPage : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public AddParentPage()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!CheckRequiredBoxesAreEmpty())
            {
                InsertDataIntoDataBase(new Parent(textBoxName.Text, textBoxSurname.Text, textBoxPhoneNumber.Text));
                logger.Info("Button NEXT was clicked");
            }
        }

        private void InsertDataIntoDataBase(Parent parent)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
                {
                    connection.Open();
                    InsertDataIntoParentOfPlayer(parent, connection);
                }
            }
            catch (Exception ex)
            {
                logger.Error($"An error occurred: {ex}");
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
                logger.Info("Window Add Parent Page was closed after inserting data of player and parent to the database");
            }
        }

        private void InsertDataIntoParentOfPlayer(Parent parent, NpgsqlConnection connection)
        {
            string insertQuery = "INSERT INTO parent_of_player(name, surname, phone_number) " +
                                 $"VALUES ('{parent.Name}', '{parent.Surname}', '{parent.PhoneNumber}')";

            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Name, Surname, and Phone Number are requierd fields
        /// </summary>
        private bool CheckRequiredBoxesAreEmpty()
        {
            bool emptyBoxes = string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text) || string.IsNullOrEmpty(textBoxPhoneNumber.Text);

            if (emptyBoxes)
            {
                logger.Info("Not all required boxes are filled. Parent Page.");
                MessageBox.Show("Name, Surname, and Phone Number are required", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return emptyBoxes;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
            logger.Info("Window Add Parent Page was closed");
        }
    }
}
