﻿using RealMadridDesktopApplication.Modules;
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
using RealMadridDesktopApplication.SQLConnection;
using System.Numerics;
using System.Data.SqlClient;
using RealMadridDesktopApplication.Password;

namespace RealMadridDesktopApplication.Forms
{
    public partial class AddEmployeePage : Form
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(comboBoxRole.Text.Equals("Admin") ? AccessModifier.Admin : AccessModifier.Coach,
                    CreateEmployeeLogin(textBoxName.Text, textBoxSurname.Text), CreateEmployeePassword(), dateTimePickerBirthday.Text.ToString().Split()[0].Split('/'))
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                AdditionalName = textBoxAdditionalName.Text,
                PhoneNumber = textBoxPhoneNumber.Text
            };

            if (!CheckRequiredBoxesAreEmpty())
            {
                InsertDataToDatabase(employee);

            }
        }

        private string CreateEmployeeLogin(string name, string surname) => name + "_" + surname;

        private string CreateEmployeePassword()
        {
            GeneratePassword generatePassword = new GeneratePassword();
            return generatePassword.Password;
        }

        private void InsertDataToDatabase(Employee employee)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(SQLConnection.SQLVariableContainer.ConnectionToSQL))
                {
                    connection.Open();
                    InsertDataIntoPersonalDetails(employee, connection);
                    InsertDataIntoEmployeeOfRealMadrid(employee, connection);
                }
                ShowMessageBoxLoginPassword(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClearTextBoxes();
            }
        }

        private void InsertDataIntoPersonalDetails(Employee employee, NpgsqlConnection connection)
        {
            string insertQuery = "INSERT INTO personal_details(name, surname, additional_name, birthday, phone_number) " +
                "VALUES ('" + employee.Name + "', '" + employee.Surname + "', '" + employee.AdditionalName + "', '" + employee.Birthday + "', '" + employee.PhoneNumber + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private void InsertDataIntoEmployeeOfRealMadrid(Employee employee, NpgsqlConnection connection)
        {
            string insertQuery = "INSERT INTO employee_of_real_madrid(role_access, personal_employee_details, login, password) " +
                "VALUES ('" + employee.RoleAccessModifier + "', " + SQLVariableContainer.SelectPersonalPlayerIdFromPersonalDetails + ", '"
                + employee.Login + "', '" + employee.Password + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAdditionalName.Clear();
            textBoxPhoneNumber.Clear();
        }

        /// <summary>
        /// Name, Surname, Role, and Phone Number are requierd fields
        /// </summary>
        private bool CheckRequiredBoxesAreEmpty()
        {
            bool emptyBoxes = string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text) ||
                string.IsNullOrEmpty(textBoxPhoneNumber.Text) || string.IsNullOrEmpty(comboBoxRole.Text);

            if (emptyBoxes)
            {
                MessageBox.Show("Name, Surname, Phone Number, and Role are required", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return emptyBoxes;
        }

        private void buttonBack_Click(object sender, EventArgs e) => Close();

        private void ShowMessageBoxLoginPassword(Employee employee) => MessageBox.Show("Login: " + employee.Login + "\nPassword: " + employee.Password, "Employee information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
}
