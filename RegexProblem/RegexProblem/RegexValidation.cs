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
        public string ValidateEmail(string email)
        {
            string emailId = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if (Regex.IsMatch(email, emailId))
            {
                Console.WriteLine("Email is Matching");
            }
            else
            {
                Console.WriteLine("Email is Not Matching");
            }
            return emailId;
        }
        public string ValidatePhoneNumber(string phonenum)
        {
            string phoneNumber = @"[0-9]{1,2}\s[0-9]{10}";
            if (Regex.IsMatch(phonenum, phoneNumber))
            {
                Console.WriteLine("PhoneNumber is Matching");
            }
            else
            {
                Console.WriteLine("PhoneNumber is Not Matching");
            }
            return phoneNumber;
        }
        public string ValidatePassword1(string password1)
        {
            string passwordRule1 = "[A-Z a-z 0-9]{8,}";
            if (Regex.IsMatch(password1, passwordRule1))
            {
                Console.WriteLine("Password1 is Matching");
            }
            else
            {
                Console.WriteLine("Password1 is Not Matching");
            }
            return passwordRule1;
        }
        public string ValidatePassword2(string password2)
        {
            string passwordRule2 = "^(?=.*?[A-Z]).{8,}$";
            if (Regex.IsMatch(password2, passwordRule2))
            {
                Console.WriteLine("Password2 is Matching");
            }
            else
            {
                Console.WriteLine("Password2 is Not Matching");
            }
            return passwordRule2;
        }
        public string ValidatePassword3(string password3)
        {
            string passwordRule3 = "^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$";
            if (Regex.IsMatch(password3, passwordRule3))
            {
                Console.WriteLine("Password3 is Matching");
            }
            else
            {
                Console.WriteLine("Password3 is Not Matching");
            }
            return passwordRule3;
        }
        public string ValidatePassword4(string password4)
        {
            string passwordRule4 = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=-]).{8,}$";
            if (Regex.IsMatch(password4, passwordRule4))
            {
                Console.WriteLine("Password4 is Matching");
            }
            else
            {
                Console.WriteLine("Password4 is Not Matching");
            }
            return passwordRule4;
        }

    }
}
