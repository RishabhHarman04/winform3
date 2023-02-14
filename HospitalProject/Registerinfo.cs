using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalProject
{
    internal class Registerinfo
    {
        public string name, email, password, confirmpassword;

        public Registerinfo(string name, string email, string password, string confirmpassword)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.confirmpassword = confirmpassword;
        }
        private Registerinfo() { }

        public bool ValidateEmail()
        {
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            return
                Regex.IsMatch(email, pattern);
        }

    }
  
}
