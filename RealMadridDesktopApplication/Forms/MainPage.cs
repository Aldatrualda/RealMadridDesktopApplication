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

namespace RealMadridDesktopApplication.Forms
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonAddNewPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerPage addPlayerPage = new AddPlayerPage();
            addPlayerPage.Show();
        }  
    }
}
