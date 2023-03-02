using System;

namespace RegexProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            regex.ValidateFirstName("Sangmeshwar");
            regex.ValidateLastName("Patil");
            regex.ValidateEmail("Patil.sangmeshwar@gmail.co.in");
            regex.ValidatePhoneNumber("91 9665679388");
            regex.ValidatePassword1("sangmeshwar96");
            regex.ValidatePassword2("Sangmeshwar96");
            regex.ValidatePassword3(".Sangmeshwar96");
        }
    }
}