using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class RegexValidation
    {
        public string ValidateFirstName(string fname)
        {
            string firstName = "^[A-Z][a-zA-Z]{2,}$";
            if (Regex.IsMatch(fname, firstName))
            {
                Console.WriteLine("FirstName is Matching");
            }
            else
            {
                Console.WriteLine("FirstName is Not Matching");
            }
            return firstName;
        }
        public string ValidateLastName(string lname)
        {
            string lastName = "^[A-Z][a-zA-Z]{2,}$";
            if (Regex.IsMatch(lname, lastName))
            {
                Console.WriteLine("LastName is Matching");
            }
            else
            {
                Console.WriteLine("LastName is Not Matching");
            }
            return lastName;
        }
    }
}
