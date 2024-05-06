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
using RealMadridDesktopApplication.SQLConnection;

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
            if (accessModifier == AccessModifier.Admin)
            {
                Show();
            }
            else if (accessModifier == AccessModifier.Coach)
            {
                RestrictedAccess();
                Show();
            }
        }

        private void ShowEmployeesFromDataBase(AccessModifier accessModifier)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLVariableContainer.ConnectionToSQL))
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!(textBoxID.Text.Equals("") && textBoxFirstName.Text.Equals("")))
            {
                if (MessageBox.Show($"Are you sure you want to delete {textBoxFirstName.Text}?", "Delete Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        using (NpgsqlConnection connection = new NpgsqlConnection(SQLVariableContainer.ConnectionToSQL))
                        {
                            connection.Open();
                            DeleteEmployee(connection, int.Parse(textBoxID.Text), GetPersonalEmployeeDetailsId(connection, textBoxID.Text));
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Info($"An error occurred: {ex}");
                        MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                buttonClean_Click(sender, e);
                textBoxID.Focus();
                MessageBox.Show("Fields ID and First Name are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Getting the personal details ID of an employee from the employee_of_real_madrid table to delete the curtain row in personal_details table.
        /// </summary>
        private int GetPersonalEmployeeDetailsId(NpgsqlConnection connection, string ID)
        {
            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(SQLVariableContainer.SelectEmployeePersonalDetailsID(int.Parse(ID)), connection))
                {
                    NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        return (int)dataTable.Rows[0][0];
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Info($"An error occurred: {ex}");
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void DeleteEmployee(NpgsqlConnection connection, int employeeID, int personalDetailsID)
        {
            using (NpgsqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    using (NpgsqlCommand commandDeletePersonalDetails = new NpgsqlCommand(SQLVariableContainer.DeletePersonalDetailsOfEmployee(personalDetailsID), connection))
                    using (NpgsqlCommand commandDeleteEmployee = new NpgsqlCommand(SQLVariableContainer.DeleteEmploeeFromRealMadridAdmin(employeeID), connection))
                    {
                        commandDeleteEmployee.Transaction = transaction;
                        commandDeletePersonalDetails.Transaction = transaction;

                        commandDeleteEmployee.ExecuteNonQuery();
                        commandDeletePersonalDetails.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    logger.Info($"An error occurred: {ex}");
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Rollback();
                }
            }
        }

        /// <summary>
        /// Using the method for coach.
        /// </summary>
        private void RestrictedAccess()
        {
            textBoxID.Visible = false;
            textBoxFirstName.Visible = false;
            labelFirstName.Visible = false;
            labelID.Visible = false;
            buttonDelete.Visible = false;
            buttonClean.Visible = false;
            buttonRefresh.Location = new System.Drawing.Point(1068, 632);
            buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;  
            employeeViewer.Dock = DockStyle.Top;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowEmployeesFromDataBase(accessModifier);
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxFirstName.Clear();
        }
    }
}