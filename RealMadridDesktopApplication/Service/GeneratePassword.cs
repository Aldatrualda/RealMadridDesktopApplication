using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RealMadridDesktopApplication.Password
{
    /// <summary>
    /// Generate a random password for a new employee. The password is 8 symbols. 
    /// Choosing a char randomly from the constant list of chars and add the char to the password StringBuilder.
    /// </summary>
    public class GeneratePassword
    {
        const string listOfChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()";

        private string password;

        public GeneratePassword() => this.password = GenerateRandomPassword(listOfChars);
        
        private string GenerateRandomPassword(string listOfChars)
        {
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                password.Append(listOfChars[random.Next(0, listOfChars.Length)]);
            }
            return password.ToString();
        }

        public string Password
        {
            get { return password; }
        }
    }
}
