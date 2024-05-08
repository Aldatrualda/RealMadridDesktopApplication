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
using RealMadridDesktopApplication.Modules;
using NLog;

namespace RealMadridDesktopApplication.Forms
{
    public partial class MainPage : Form
    {

        Logger logger = LogManager.GetCurrentClassLogger();
        private LoginPage loginPage;
        AccessModifier accessModifier;

        public MainPage(AccessModifier accessModifier, LoginPage loginPage)
        {
            logger.Info("Main Page openned");
            InitializeComponent();
            this.loginPage = loginPage;
            this.accessModifier = accessModifier;

            if (accessModifier == AccessModifier.Admin)
            {
                Show();
            }
            else if (accessModifier == AccessModifier.Coach)
            {
                buttonAddEmployee.Visible = false;
                buttonAddNewPlayer.Visible = false;
                buttonShowEmployees.Location = new Point(227, 255);
                Show();
            }
        }

        private void buttonAddNewPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerPage addPlayerPage = new AddPlayerPage();
            addPlayerPage.Show();
            logger.Info("Window Add Player Page was opened");
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeePage addEmployeePage = new AddEmployeePage();
            addEmployeePage.Show();
            logger.Info("Window Add Employee Page was opened");
        }

        private void buttonShowAllPlayers_Click(object sender, EventArgs e)
        {
            ShowPlayerPage showPlayerPage = new ShowPlayerPage();
            showPlayerPage.Show();
            logger.Info("Window Show Player Page was opened");
        }

        private void buttonShowEmployees_Click(object sender, EventArgs e)
        {
            ShowEmployeePage showEmployeePage = new ShowEmployeePage(accessModifier);
            showEmployeePage.Show();
            logger.Info("Window Show Employee Page was opened");
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Dispose();
                loginPage.Show();
            }
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPage.Dispose();
        }
    }
}
