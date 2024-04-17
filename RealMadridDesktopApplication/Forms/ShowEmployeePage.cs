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
using RealMadridDesktopApplication.Modules;

namespace RealMadridDesktopApplication.Forms
{
    public partial class ShowEmployeePage : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private AccessModifier accessModifier;
        public ShowEmployeePage(AccessModifier accessModifier)
        {
            InitializeComponent();
            this.accessModifier = accessModifier;
            ShowEmployeesFromDataBase(accessModifier);
        }

        private void ShowEmployeesFromDataBase(AccessModifier accessModifier)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();

                    if (accessModifier == AccessModifier.Admin)
                    {
                        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(SQLConnection.SQLVariableContainer.SelectEmployeesFromRealMadridAdmin, connection);
                        dataAdapter.Fill(dataTable);
                    }
                    else if (accessModifier == AccessModifier.Coach)
                    {
                        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(SQLConnection.SQLVariableContainer.SelectEmployeesFromRealMadridRestricted, connection);
                        dataAdapter.Fill(dataTable);
                        employeeViewer.Columns["login"].Visible = false;
                        employeeViewer.Columns["password"].Visible = false;
                    }
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
