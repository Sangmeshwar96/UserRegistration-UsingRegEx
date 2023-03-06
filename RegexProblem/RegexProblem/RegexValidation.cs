using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace RegexProblem
{
    public class RegexValidation
    {
        public bool ValidateFirstName(string fname)
        {
            string firstName = "^[A-Z][a-zA-Z]{2,}$";
            try
            {
                if (fname.Equals(string.Empty))
                {
                    throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.EMPTY_INPUT, "First Name should not be empty");
                }
                return Regex.IsMatch(fname, firstName);
            }
            catch(NullReferenceException)
            {
                throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.NULL_INPUT, "First Name should not be null");
            }
        }
        public bool ValidateLastName(string lname)
        {
            string lastName = "^[A-Z][a-zA-Z]{2,}$";
            try
            {
                if (lname.Equals(string.Empty))
                {
                    throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.EMPTY_INPUT, "Last Name should not be empty");
                }
                return Regex.IsMatch(lname, lastName);
            }
            catch (NullReferenceException)
            {
                throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.NULL_INPUT, "last Name should not be null");
            }
        }
        public bool ValidateEmail(string email)
        {
            string emailId = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.EMPTY_INPUT, "Email should not be empty");
                }
                return Regex.IsMatch(email, emailId);
            }
            catch (NullReferenceException)
            {
                throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.NULL_INPUT, "Email should not be null");
            }
        }
        public bool ValidatePhoneNumber(string phonenum)
        {
            string phoneNumber = @"[0-9]{1,2}\s[0-9]{10}";
            try
            {
                if (phonenum.Equals(string.Empty))
                {
                    throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.EMPTY_INPUT, "PhoneNumber should not be empty");
                }
                return Regex.IsMatch(phonenum, phoneNumber);
            }
            catch (NullReferenceException)
            {
                throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.NULL_INPUT, "PhoneNumber should not be null");
            }
        }
        public bool ValidatePassword1(string password1)
        {
            string passwordRule1 = "[A-Z a-z 0-9]{8,}";
            try
            {
                if (password1.Equals(string.Empty))
                {
                    throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                return Regex.IsMatch(password1, passwordRule1);
            }
            catch (NullReferenceException)
            {
                throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }
        }
        public bool ValidatePassword2(string password2)
        {
            string passwordRule2 = "^(?=.*?[A-Z]).{8,}$";
            try
            {
                if (password2.Equals(string.Empty))
                {
                    throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                return Regex.IsMatch(password2, passwordRule2);
            }
            catch (NullReferenceException)
            {
                throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }
        }
        public bool ValidatePassword3(string password3)
        {
            string passwordRule3 = "^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$";
            try
            {
                if (password3.Equals(string.Empty))
                {
                    throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                return Regex.IsMatch(password3, passwordRule3);
            }
            catch (NullReferenceException)
            {
                throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }
        }
        public bool ValidatePassword4(string password4)
        {
            string passwordRule4 = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=-]).{8,}$";
            try
            {
                if (password4.Equals(string.Empty))
                {
                    throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                return Regex.IsMatch(password4, passwordRule4);
            }
            catch (NullReferenceException)
            {
                throw new RegexProblemCustomException(RegexProblemCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }
        }

    }
}
