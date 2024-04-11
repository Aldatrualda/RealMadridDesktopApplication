using Microsoft.VisualBasic.Logging;
using Npgsql;
using RealMadridDesktopApplication.Forms;
using RealMadridDesktopApplication.Modules;
using System.Data;
using NLog;
namespace RealMadridDesktopApplication
{
    public partial class LoginPage : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public LoginPage()
        {
            logger.Info("Login Page was opened");
            InitializeComponent();
            logger.Info("Login Page was closed");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e) => LoginEmployee();

        private void LoginEmployee()
        {
            logger.Info("Button {Login} was clicked");
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
                logger.Error($"An error occurred: {ex}");
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var accesModifier = GetAccessModifierOfAccount(login, password);
                if (accesModifier.Equals("admin"))
                {
                    new MainPage(AccessModifier.Admin);
                }
                else
                {
                    new MainPage(AccessModifier.Coach);
                }
            }
            else
            {
                logger.Info("Invalid login details were typed");
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                //focus mouse on the text box login
                textBoxLogin.Focus();
            }
        }

        private string GetAccessModifierOfAccount(string login, string password)
        {
            var accessModifier = "";

            using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(SQLConnection.SQLVariableContainer.SelectAccessModifierOfUser(login, password), connection))
                {
                    try
                    {
                        connection.Open();
                        NpgsqlDataReader dataReader = command.ExecuteReader();
                        if (dataReader.Read())
                        {
                            accessModifier = dataReader.GetString(0);
                        }
                        else
                        {
                            accessModifier = "isn't defined";
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Error($"An error occurred: {ex}");
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return accessModifier;
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
