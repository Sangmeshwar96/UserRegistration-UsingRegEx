using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationLambda
{
    public class User
    {
        public Regex FirstName = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public Regex LastName = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public Regex Emails = new Regex(@"^[a-zA-Z0-9]+([-.+_#$][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$");
        public Regex PhoneNumber = new Regex(@"[0-9]{1,2}\s[0-9]{10}");
        public Regex Password1 = new Regex(@"[A-Z a-z 0-9]{8,}$");
        public Regex Password2 = new Regex(@"^(?=.*?[A-Z]).{8,}$");
        public Regex Password3 = new Regex(@"^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$");
        public Regex Password4 = new Regex(@"^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=-]).{8,}$");

    }
}
