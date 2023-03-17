using System;
using System.Text.RegularExpressions;
using UserRegistrationLambda;

namespace UserRegistrationLamda
{
    public class RegExValidation
    {
        List<User> userList = new List<User>();
        public RegExValidation()
        {
            User user = new User();
            userList.Add(user);
        }
        public void CheckFirstName(string firstName)
        {
            if(userList.Any(x=>x.FirstName.IsMatch(firstName)))
            {
                Console.WriteLine("It is a Valid FirstName.");
            }
            else
            {
                Console.WriteLine("It is not a Valid FirstName.");
            }
        }
        public void CheckLastName(string lastName)
        {
            if (userList.Any(x => x.LastName.IsMatch(lastName)))
            {
                Console.WriteLine("It is a Valid LastName.");
            }
            else
            {
                Console.WriteLine("It is not a Valid LastName.");
            }
        }
        public void CheckEmail(string eMail)
        {
            if (userList.Any(x => x.Emails.IsMatch(eMail)))
            {
                Console.WriteLine("It is a Valid Email.");
            }
            else
            {
                Console.WriteLine("It is not a Valid Email.");
            }
        }
        public void CheckPhoneNumber(string number)
        {
            if (userList.Any(x => x.PhoneNumber.IsMatch(number)))
            {
                Console.WriteLine("It is a Valid PhoneNumber.");
            }
            else
            {
                Console.WriteLine("It is not a Valid PhoneNumber.");
            }
        }
        public void CheckPassword1(string password1)
        {
            if (userList.Any(x => x.Password1.IsMatch(password1)))
            {
                Console.WriteLine("It is a Valid password1.");
            }
            else
            {
                Console.WriteLine("It is not a Valid password1.");
            }
        }
        public void CheckPassword2(string password2)
        {
            if (userList.Any(x => x.Password2.IsMatch(password2)))
            {
                Console.WriteLine("It is a Valid password2.");
            }
            else
            {
                Console.WriteLine("It is not a Valid password2.");
            }
        }
        public void CheckPassword3(string password3)
        {
            if (userList.Any(x => x.Password1.IsMatch(password3)))
            {
                Console.WriteLine("It is a Valid password3.");
            }
            else
            {
                Console.WriteLine("It is not a Valid password3.");
            }
        }
        public void CheckPassword4(string password4)
        {
            if (userList.Any(x => x.Password4.IsMatch(password4)))
            {
                Console.WriteLine("It is a Valid password4.");
            }
            else
            {
                Console.WriteLine("It is not a Valid password4.");
            }
        }

    }
}
