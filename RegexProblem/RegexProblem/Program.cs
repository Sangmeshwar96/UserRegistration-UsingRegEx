using System;

namespace RegexProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            bool flag = true;
            while(flag)
            {
                Console.WriteLine("\nWelcome to User Registration program using Regex patterns\n");
                Console.WriteLine("Select Option : " + "\n1.User Validation Check" + "\n2.Sample Emails Validation\n"+"3.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("User Validation Check : ");
                        RegexValidation regex = new RegexValidation();
                        regex.ValidateFirstName("Sangmeshwar");
                        regex.ValidateLastName("Patil");
                        regex.ValidateEmail("Patil.sangmeshwar@gmail.co.in");
                        regex.ValidatePhoneNumber("91 9665679388");
                        regex.ValidatePassword1("sangmeshwar96");
                        regex.ValidatePassword2("Sangmeshwar96");
                        regex.ValidatePassword3(".Sangmeshwar96");
                        regex.ValidatePassword4(".Sangmeshwar*96");
                        break;
                    case 2:
                        Console.WriteLine("\nChecking the sample email address");
                        Console.WriteLine("\nSample Emails Validation : ");
                        SampleEmails emailsCheck = new SampleEmails();
                        string email1 = "abc@yahoo.com"; //valid
                        emailsCheck.CheckEmails(email1);
                        string email2 = "abc-100@yahoo.com"; //valid
                        emailsCheck.CheckEmails(email2);
                        string email3 = "abc.100@yahoo.com"; //valid
                        emailsCheck.CheckEmails(email3);
                        string email4 = "abc111@abc.com"; //valid
                        emailsCheck.CheckEmails(email4);
                        string email5 = "abc-100@abc.net"; //valid
                        emailsCheck.CheckEmails(email5);
                        string email6 = "abc.100@abc.com.au"; //valid
                        emailsCheck.CheckEmails(email6);
                        string email7 = "abc@1.com"; //invalid
                        emailsCheck.CheckEmails(email7);
                        string email8 = "abc@gmail.com.com"; //valid
                        emailsCheck.CheckEmails(email8);
                        string email9 = "abc+100@gmail.com"; //valid
                        emailsCheck.CheckEmails(email9);
                        break;
                    case 3:
                        Console.WriteLine("Thank you !!!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Selected Wrong Option Please Select Right Option !!!");
                        break;
                }
            }
            
        }
    }
}