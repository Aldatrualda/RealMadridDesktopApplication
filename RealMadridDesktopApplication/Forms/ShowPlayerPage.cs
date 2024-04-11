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
            ShowDataFromDatabase();
        }

        private void ShowDataFromDatabase()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
                {
                    connection.Open();

                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(SQLConnection.SQLVariableContainer.SelectPlayersFromRealMadrid, connection);
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
    }
}