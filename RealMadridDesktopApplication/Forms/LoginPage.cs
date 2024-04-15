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

            using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
            {
                try
                {
                    connection.Open();
                    CheckEmployeeDataBase(SQLConnection.SQLVariableContainer.GetCountFromEmployeeOfRealMadrid(textBoxLogin.Text, textBoxPassword.Text), connection);
                }
                catch (Exception ex)
                {
                    logger.Error($"An error occurred: {ex}");
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckEmployeeDataBase(string countQuery, NpgsqlConnection connection)
        {
            bool employeeLogin = false;

            using (NpgsqlCommand command = new NpgsqlCommand(countQuery, connection))
            {
                NpgsqlDataReader dataReader = command.ExecuteReader();
                employeeLogin = dataReader.Read();
            }

            if (employeeLogin)
            {
                if (GetAccessModifierOfAccount(textBoxLogin.Text, textBoxPassword.Text) == AccessModifier.Admin)
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
                // Focus mouse on the text box login.
                textBoxLogin.Focus();
            }
        }

        private AccessModifier GetAccessModifierOfAccount(string login, string password)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(SQLConnection.SQLVariableContainer.SelectAccessModifierOfUser(login, password), connection))
                {
                    try
                    {
                        connection.Open();
                        NpgsqlDataReader dataReader = command.ExecuteReader();

                        return dataReader.Read() 
                            ? dataReader.GetString(0) == "admin"
                                ? AccessModifier.Admin 
                                : AccessModifier.Coach
                            : AccessModifier.Empty;
                    }
                    catch (Exception ex)
                    {
                        logger.Error($"AccessModifier has an error. An error occurred: {ex}");
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return AccessModifier.Empty;
                    }
                }
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
