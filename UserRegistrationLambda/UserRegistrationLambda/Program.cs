using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationLamda
{
    class Program
    {
        public static void Main(string[] args)
        {
            RegExValidation regExValidation = new RegExValidation();
            regExValidation.CheckFirstName("Sangmeshwar");
            regExValidation.CheckLastName("Patil");
            regExValidation.CheckEmail("Patil.sangmeshwar@gmail.co.in");
            regExValidation.CheckPhoneNumber("91 9665679388");
            regExValidation.CheckPassword1("sangmeshwar96");
            regExValidation.CheckPassword2("Sangmeshwar96");
            regExValidation.CheckPassword3(".Sangmeshwar96");
            regExValidation.CheckPassword4(".Sangmeshwar*96");
            Console.ReadLine();
        }
    }
}