using RealMadridDesktopApplication.Modules;
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
            Employee employee = createEmployee();
            insertDataToDatabase(employee);
        }

        private Employee createEmployee()
        {

            AccessModifier accessModifier = new AccessModifier();
            string roleAccessModifier = comboBoxRole.Text;
            switch (roleAccessModifier)
            {
                case "Admin":
                    accessModifier = AccessModifier.Admin;
                    break;
                case "Coach":
                    accessModifier = AccessModifier.Coach;
                    break;
            }

            Employee employee = new Employee(accessModifier, createEmployeeLogin(textBoxName.Text, textBoxSurname.Text), createEmployeePassword());
            employee.Name = textBoxName.Text;
            employee.Surname = textBoxSurname.Text;
            employee.AdditionalName = textBoxAdditionalName.Text;
            string[] birthdayBuffer = dateTimePickerBirthday.Text.ToString().Split()[0].Split('/');
            employee.Birthday = birthdayBuffer[2] + "-" + birthdayBuffer[1] + "-" + birthdayBuffer[0];
            employee.PhoneNumber = textBoxPhoneNumber.Text;
            return employee;
        }

        private string createEmployeeLogin(string name, string surname)
        {
            return name + "_" + surname;
        }

        private string createEmployeePassword()
        {
            return "password";
        }

        private NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(SQLConnection.SQLConnection.ConnectionToSQL);
        }

        private void insertDataIntoPersonalDetails(Employee employee, NpgsqlConnection connection)
        {
            string insertQuery = "INSERT INTO personal_details(name, surname, additional_name, birthday, phone_number) " +
                "VALUES ('" + employee.Name + "', '" + employee.Surname + "', '" + employee.AdditionalName + "', '" + employee.Birthday + "', '" + employee.PhoneNumber + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private void insertDataIntoEmployeeOfRealMadrid(Employee employee, NpgsqlConnection connection)
        {
            string insertQuery = "INSERT INTO employee_of_real_madrid(role_access, personal_employee_details, login, password) " +
                "VALUES ('" + employee.RoleAccessModifier + "', " + SQLConnection.SQLConnection.SelectPersonalPlayerIdFromPersonalDetails() + ", '"
                + employee.Login + "', '" + employee.Password + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private void insertDataToDatabase(Employee employee)
        {
            try
            {
                using (NpgsqlConnection connection = GetConnection())
                {
                    connection.Open();
                    insertDataIntoPersonalDetails(employee, connection);
                    insertDataIntoEmployeeOfRealMadrid(employee, connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAdditionalName.Clear();
        }
    }
}
