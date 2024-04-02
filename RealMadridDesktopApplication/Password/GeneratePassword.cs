using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RealMadridDesktopApplication.Password
{

    public class GeneratePassword
    {
        private string listOfChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";

        private string password;

        public GeneratePassword() => this.password = GenerateRandomPassword(listOfChars);
        
        private string GenerateRandomPassword(string listOfChars)
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                int randomIndex = random.Next(0, listOfChars.Length);
                password.Append(listOfChars[randomIndex]);
            }

            return password.ToString();
        }

        public string Password
        {
            get { return password; }
        }
    }
}
