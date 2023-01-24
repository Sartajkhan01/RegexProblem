﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex01
{
    public class PasswordRules
    {
        public Regex Password_Regex = new Regex("^[A-Za-z0-9]{8,16}$");
        public void ValidatePassword()
        {
            Console.Write("Enter the password : ");
            string password = Console.ReadLine();

            if (Password_Regex.IsMatch(password))
            {
                Console.WriteLine("The password is valid ");
            }
            else
            {
                Console.WriteLine("Invalid passord");
            }
        }
        public Regex Password_Regex2 = new Regex("^[A-Z]{1,8}[a-z0-9]{7,}$");
        public void ValidatePassword2()
        {
            Console.Write("Enter the password : ");
            string password2 = Console.ReadLine();

            if (Password_Regex2.IsMatch(password2))
            {
                Console.WriteLine("The password is valid ");
            }
            else
            {
                Console.WriteLine("Invalid passord");
            }
        }

    }
}
