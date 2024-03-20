using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMadridDesktopApplication.Modules
{
    public class PersonalDetails
    {
        private string name;
        private string surname;
        private string additionalName;
        private string birthday;
        private string phoneNumber;

        public PersonalDetails(string name, string surname, string additionalName, string birthday, string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.additionalName = additionalName;
            this.birthday = birthday;
            this.phoneNumber = phoneNumber;
        }

        //Getters and Setters 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string AdditionalName
        {
            get { return additionalName; }
            set { additionalName = value; }
        }
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
