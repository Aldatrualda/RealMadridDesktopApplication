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
            Birthday = birthdayBuffer[2] + "-" + birthdayBuffer[1] + "-" + birthdayBuffer[0];
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

    public enum AccessModifier
    {
        Admin = 1,
        Coach = 2
    }
}
