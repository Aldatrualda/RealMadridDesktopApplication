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

        private AccessModifier accessModifier;

        public MainPage(AccessModifier accessModifier)
        {
            logger.Info("Main Page openned");
            InitializeComponent();

            this.accessModifier = accessModifier;

            if (accessModifier.Equals("admin"))
            {
                Show();
            }
            else if (accessModifier.Equals("coach"))
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
            ShowEmployeePage showEmployeePage = new ShowEmployeePage();
            showEmployeePage.Show();
            logger.Info("Window Show EMployee Page was opened");
        }
    }
}
