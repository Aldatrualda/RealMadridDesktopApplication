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
        public Player(string natinality, string address, string location, string[] birthdayBuffer) : base("", "", "", "", "")
        {
            this.natinality = natinality;
            this.address = address;
            this.location = location;
            Birthday = birthdayBuffer[2] + "-" + birthdayBuffer[1] + "-" + birthdayBuffer[0];
        }

        //Getters and Setters
        public string Nationality
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
