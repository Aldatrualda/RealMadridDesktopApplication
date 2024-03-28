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
using RealMadridDesktopApplication.Modules;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RealMadridDesktopApplication.Forms
{
    public partial class AddParentPage : Form
    {
        public AddParentPage()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Parent parent = CreateParent();
            InsertDataIntoDataBase(parent);
        }

        private Parent CreateParent()
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            Parent parent = new Parent(name, surname, phoneNumber);
            return parent;
        }

        private void InsertDataIntoDataBase(Parent parent)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLConnection.ConnectionToSQL))
                {
                    connection.Open();
                    InsertDataIntoParentOfPlayer(parent, connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void InsertDataIntoParentOfPlayer(Parent parent, NpgsqlConnection connection)
        {
            string insertQuery = "INSERT INTO parent_of_player(name, surname, phone_number) " +
                                 "VALUES ('" + parent.Name + "', '" + parent.Surname + "', '" + parent.PhoneNumber + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
}
