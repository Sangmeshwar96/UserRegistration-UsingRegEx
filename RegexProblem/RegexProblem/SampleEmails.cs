﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class SampleEmails
    {
        public string email = "^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
        public string CheckEmails(string sample)
        {
            if (Regex.IsMatch(sample, email))
                Console.WriteLine("Valid email address");
            else
                Console.WriteLine("Invalid email address");
            return email;
        }
    }
}
