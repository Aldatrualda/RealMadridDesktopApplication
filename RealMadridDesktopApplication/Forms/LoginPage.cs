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
            try
            {
                using (NpgsqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string selectQuery = SelectDataFromEmployeeOfRealMadrid();
                    
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GetConnection().Close();
            }
        }

        private string SelectDataFromEmployeeOfRealMadrid()
        {
            return "SELECT * FROM employee_of_real_madrid WHERE login = '" + textBoxLogin.Text + "'AND password = '" + textBoxPassword.Text + "'";
        }

        private NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection("Host=localhost;Port=5432;Database=RealMadridDB;Username=postgres;Password=123456");
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
