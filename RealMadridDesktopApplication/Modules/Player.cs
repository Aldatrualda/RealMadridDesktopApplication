using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMadridDesktopApplication.Modules
{
    public class Player : PersonalDetails
    {
        private string natinality;
        private string address;
        private string location;
        public Player(string natinality, string address, string location) : base("", "", "", "", "")
        {
            this.natinality = natinality;
            this.address = address;
            this.location = location;
        }

        //Getters and Setters
        public string nationality
        {
            get { return natinality; }
            set { natinality = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Location {
            get { return location; }
            set { location = value; }
        }
    }
}
