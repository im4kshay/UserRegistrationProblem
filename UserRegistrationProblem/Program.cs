﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("=-=-=-=-=-=-=-=Welcome To the User Registration Problem=-=-=-=-=-=-=-=");
            Console.WriteLine("----------------------------------------------------------------------");

            //object created
            UserRegistrationValidation validate = new UserRegistrationValidation();

            Console.WriteLine("Enter First Name : ");
            string firstName = Console.ReadLine();
            bool fNameResult = validate.ValidateFirstName(firstName);
            validate.PrintResult(fNameResult);


            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Enter Last Name : ");
            string lastName = Console.ReadLine();
            bool lNameResult = validate.ValidateLastName(lastName);
            validate.PrintResult(lNameResult);

            Console.WriteLine("--------------------------------------");

            Console.ReadLine();
        }
    }
}
