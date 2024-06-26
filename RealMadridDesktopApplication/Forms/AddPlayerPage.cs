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
using System.Numerics;

namespace RealMadridDesktopApplication.Forms
{
    public partial class AddPlayerPage : Form
    {
        public static string ConnectionString = "Host=localhost;Port=5432;Database=RealMadridDB;Username=postgres;Password=123456";
        public AddPlayerPage()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Player player = CreatePlayer();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();
                    InsertDataIntoPersonalDetails(connection, player);
                    InsertDataIntoPlayerOfRealMadrid(connection, player);
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

        private void InsertDataIntoPersonalDetails(NpgsqlConnection connection, Player player)
        {
            string insertQuery = "INSERT INTO personal_details(name, surname, additional_name, birthday, phone_number) " +
                "VALUES('" + player.Name + "', '" + player.Surname + "', '" + player.AdditionalName + "', '" + player.Birthday + "', '" + player.PhoneNumber + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private void InsertDataIntoPlayerOfRealMadrid(NpgsqlConnection connection, Player player)
        {
            string insertQuery = "INSERT INTO player_of_real_madrid(personal_player_details, nationality, address, location)" +
                " VALUES(" + SelectPersonalPlayerIdFromPersonalDetails() + ", '" + player.Nationality + "', '" + player.Address + "', '" + player.Location + "')";
            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private string SelectPersonalPlayerIdFromPersonalDetails()
        {
            return "(SELECT personal_details_id FROM personal_details ORDER BY personal_details_id DESC LIMIT 1)";
        }

        private Player CreatePlayer()
        {
            Player player = new Player(comboBoxNationality.Text, textBoxAddress.Text, comboBoxLocation.Text);
            player.Name = textBoxName.Text;
            player.Surname = textBoxSurname.Text;
            player.AdditionalName = textBoxAdditionalName.Text;
            string[] birthdayBuffer = dateBirthday.Text.ToString().Split()[0].Split('/');
            player.Birthday = birthdayBuffer[2] + "-" + birthdayBuffer[1] + "-" + birthdayBuffer[0];
            player.PhoneNumber = textBoxPhoneNumber.Text;
            return player;
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxAdditionalName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxAddress.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }
    }
}
