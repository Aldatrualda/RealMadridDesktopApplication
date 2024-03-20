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
        public Employee(AccessModifier roleAccessModifier, string login, string password) : base("", "", "", "", "")
        {
            // Вообще эту конструкцию я бы по-другому немого селал, потому что передвать строчку не совсем круто,
            // а вот перердавать enum было бы лучше, потому что теперь есть определенная выборка.
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
        }

        //Getters and Setters
        
        // Можно и так, но я сделал одно поле по-другому.
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
        // Зачем счет?
        Admin = 1,
        Coach = 2
    }
}
