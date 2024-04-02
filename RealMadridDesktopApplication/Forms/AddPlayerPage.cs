using RealMadridDesktopApplication.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Numerics;

namespace RealMadridDesktopApplication.Forms
{
    public partial class AddPlayerPage : Form
    {
        public AddPlayerPage()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (!(CheckRequiredBoxesAreEmpty()))
            {
                InsertDateToDatabase(new Player(comboBoxNationality.Text, textBoxAddress.Text,
                    comboBoxLocation.Text, dateBirthday.Text.ToString().Split()[0].Split('/'))
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    AdditionalName = textBoxAdditionalName.Text,
                    PhoneNumber = textBoxPhoneNumber.Text
                });
            }
        }

        private void InsertDateToDatabase(Player player)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
                {
                    connection.Open();
                    InsertDataIntoPersonalDetails(connection, player);
                    InsertDataIntoPlayerOfRealMadrid(connection, player);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClearTextBoxes();
                new AddParentPage().Show();
            }
        }

        private void InsertDataIntoPersonalDetails(NpgsqlConnection connection, Player player)
        {
            string insertQuery = "INSERT INTO personal_details(name, surname, additional_name, birthday, phone_number) " +
                "VALUES ('" + player.Name + "', '" + player.Surname + "', '" + player.AdditionalName + "', '" + player.Birthday + "', '" + player.PhoneNumber + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private void InsertDataIntoPlayerOfRealMadrid(NpgsqlConnection connection, Player player)
        {
            string insertQuery = "INSERT INTO player_of_real_madrid(personal_player_details, nationality, address, location)" +
                " VALUES (" + SQLConnection.SQLVariableContainer.SelectPersonalPlayerIdFromPersonalDetails + ", '" + player.Nationality + "', '" + player.Address + "', '" + player.Location + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAdditionalName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxAddress.Clear();
        }

        /// <summary>
        /// Name, Surname, and Location are requierd fields
        /// </summary>
        private bool CheckRequiredBoxesAreEmpty()
        {
            bool emptyBoxes = string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text)
                                || string.IsNullOrEmpty(comboBoxLocation.Text);

            if (emptyBoxes)
            {
                MessageBox.Show("Name, Surname, and Location are required", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return emptyBoxes;
        }

        private void buttonBack_Click(object sender, EventArgs e) => Close();

    }
}
