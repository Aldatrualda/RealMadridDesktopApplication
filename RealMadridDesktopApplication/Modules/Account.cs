using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealMadridDesktopApplication.Modules
{
    public class Account
    {
        private string accessModifier;

        public Account(string accessModifier)
        {
            this.accessModifier = accessModifier;
        }

        public string AccessModifier
        {
            get { return accessModifier; }
            set { accessModifier = value; }
        }
    }
}
