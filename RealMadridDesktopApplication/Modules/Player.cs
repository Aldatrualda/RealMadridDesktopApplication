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

        /// <summary>
        /// I get the string array "birthdayBuffer" that contains year, month, and day. These digits are their place in the array.
        /// </summary>
        const int BIRTHDAY_YEAR = 2;
        const int BIRTHDAY_MONTH = 1;
        const int BIRTHDAY_DAY = 0;
        public Player(string natinality, string address, string location, string[] birthdayBuffer) : base("", "", "", "", "")
        {
            this.natinality = natinality;
            this.address = address;
            this.location = location;
            Birthday = birthdayBuffer[BIRTHDAY_YEAR] + "-" + birthdayBuffer[BIRTHDAY_MONTH] + "-" + birthdayBuffer[BIRTHDAY_DAY];
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
