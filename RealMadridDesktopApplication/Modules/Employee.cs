using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMadridDesktopApplication.Modules
{
    public class Employee : PersonalDetails
    {
        private int roleAccessModifier;
        private string login;
        private string password;
        public Employee(string roleAccessModifier, string login, string password) : base("", "", "", "", "")
        {
            switch (roleAccessModifier)
            {
                case "Admin":
                    this.roleAccessModifier = (int)AccessModifier.Admin;
                    break;
                case "Coach":
                    this.roleAccessModifier = (int)AccessModifier.Coach;
                    break;
            }
            this.login = login;
            this.password = password;
        }

        //Getters and Setters
        public int RoleAccessModifier
        {
            get { return roleAccessModifier; }
            set { roleAccessModifier = value; }
        }
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

    enum AccessModifier
    {
        Admin = 1,
        Coach = 2
    }
}
