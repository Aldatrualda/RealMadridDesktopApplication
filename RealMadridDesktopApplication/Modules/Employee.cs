using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMadridDesktopApplication.Modules
{
    public class Employee : PersonalDetails
    {
        public int RoleAccessModifier { get; set; }
        private string login;
        private string password;

        /// <summary>
        /// I get the string array "birthdayBuffer" that contains year, month, and day. These digits are their place in the array.
        /// </summary>
        const int BIRTHDAY_YEAR = 2;
        const int BIRTHDAY_MONTH = 1;
        const int BIRTHDAY_DAY = 0;
        public Employee(AccessModifier roleAccessModifier, string login, string password, string[] birthdayBuffer) : base("", "", "", "", "")
        {
            switch (roleAccessModifier)
            {
                case AccessModifier.Admin:
                    RoleAccessModifier = (int)AccessModifier.Admin;
                    break;
                default:
                case AccessModifier.Coach:
                    RoleAccessModifier = (int)AccessModifier.Coach;
                    break;
            }

            this.login = login;
            this.password = password;
            Birthday = birthdayBuffer[BIRTHDAY_YEAR] + "-" + birthdayBuffer[BIRTHDAY_MONTH] + "-" + birthdayBuffer[BIRTHDAY_DAY];
        }

        //Getters and Setters
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
