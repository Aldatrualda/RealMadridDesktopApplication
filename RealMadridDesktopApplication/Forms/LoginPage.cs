using Microsoft.VisualBasic.Logging;
using Npgsql;
using RealMadridDesktopApplication.Forms;
using System.Data;
namespace RealMadridDesktopApplication
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginEmployee();
        }

        private void LoginEmployee()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
                {
                    connection.Open();
                    CreateDataAdapter(SQLConnection.SQLVariableContainer.SelectDataFromEmployeeOfRealMadrid(textBoxLogin.Text, textBoxPassword.Text), connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Hide();
            }
        }

        private void CreateDataAdapter(string selectQuery, NpgsqlConnection connection)
        {
            string login;
            string password;
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(selectQuery, connection);

            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                login = textBoxLogin.Text;
                password = textBoxPassword.Text;
                new MainPage().Show();
            }
            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                //focus mouse on the text box login
                textBoxLogin.Focus();
            }
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else if (!checkBoxShow.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }

        }
    }
}
