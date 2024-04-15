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
using Microsoft.Extensions.Logging;

namespace RealMadridDesktopApplication.Forms
{
    public partial class ShowEmployeePage : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public ShowEmployeePage()
        {
            InitializeComponent();
            ShowEmployeesFromDataBase();
        }

        private void ShowEmployeesFromDataBase()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
                {
                    connection.Open();
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(SQLConnection.SQLVariableContainer.SelectEmployeesFromRealMadrid, connection);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    employeeViewer.AutoGenerateColumns = false;
                    employeeViewer.DataSource = dataTable;
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
            Close();
            logger.Info("Window Show Employee Page was closed");
        }
    }
}
