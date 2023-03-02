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
        }
    }
}