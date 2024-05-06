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
using NLog;


namespace RealMadridDesktopApplication.Forms
{
    public partial class ShowPlayerPage : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public ShowPlayerPage()
        {
            InitializeComponent();
        }

        private void ShowDataFromDatabase(string nationality, string location, int ageGroup)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
                {
                    connection.Open();

                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(SQLConnection.SQLVariableContainer.SelectFilteredPlayersFromRealMadrid(nationality, location, ageGroup), connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    playerViewer.AutoGenerateColumns = false;
                    playerViewer.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                logger.Info($"An error occurred: {ex}");
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            logger.Info("Window Show Player Page was closed");
        }

        /// <summary>
        /// Where 0 is "None" in the comboBoxes of Show Player Page. 
        /// </summary>
        private void buttonClean_Click(object sender, EventArgs e)
        {
            comboBoxAge.SelectedIndex = 0;
            comboBoxLocation.SelectedIndex = 0;
            comboBoxNationality.SelectedIndex = 0;
        }

        /// <summary>
        /// If an user chooses "None" in the comboBox AgeGroup therefore the return data shows all players.
        /// </summary>
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            int age;
            switch (comboBoxAge.Text)
            {
                case "U-7":
                    age = 7;
                    break;
                case "U-11":
                    age = 11;
                    break;
                case "U-13":
                    age = 13;
                    break;
                case "U-15":
                    age = 15;
                    break;
                case "U-17":
                    age = 17;
                    break;
                default:
                    age = 100;
                    break;
            }
            ShowDataFromDatabase(comboBoxNationality.Text, comboBoxLocation.Text, age);
        }
    }
}