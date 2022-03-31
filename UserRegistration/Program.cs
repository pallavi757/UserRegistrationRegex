﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static void Main(String[] args)
        {
            int choice=0;
            Validation validation = new Validation();

            do
            {
                Console.WriteLine("Enter 1 for First name");
                Console.WriteLine("Enter 2 for Last name");
                Console.WriteLine("Enter 3 for Email");
                Console.WriteLine("Enter 4 for Mobile Number");
                Console.WriteLine("Enter 5 for Password");
                Console.WriteLine("Enter 6 Password should have at least 1 uppercase ");
                Console.WriteLine("Enter 7 Password should have at least 1 number ");
                Console.WriteLine("Enter 8 Password has exactly 1 special character ");
                Console.WriteLine("Enter 9 Check sample email");
                Console.WriteLine("Enter 0 to Exit");
                try
                {                 
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {                    
                        case 1:
                            Console.Write("Enter Your First Name: ");
                            string firstname = Console.ReadLine();
                            validation.firstname(firstname);
                            break;
                        case 2:
                            Console.Write("Enter Your Last Name: ");
                            string lastname = Console.ReadLine();
                            validation.lastname(lastname);
                            break;
                        case 3:
                            Console.Write("Enter Your Email: ");
                            string email = Console.ReadLine();
                            validation.email(email);
                            break;
                        case 4:
                            Console.Write("Enter Your MOB: ");
                            string MobileNo = Console.ReadLine();
                            validation.mobile(MobileNo);
                            break;
                        case 5:
                            Console.Write("Please enter your password: ");
                            string pass = Console.ReadLine();
                            validation.password(pass);
                            break;
                        case 6:
                            Console.Write("Please enter your password: ");
                            string pass_1 = Console.ReadLine();
                            validation.password(pass_1);
                            break;
                        case 7:
                            Console.Write("Please enter your password: ");
                            string pass_2 = Console.ReadLine();
                            validation.password(pass_2);
                            break;
                        case 8:
                            Console.Write("Please enter your password: ");
                            string pass_3 = Console.ReadLine();
                            validation.password_Special_Char(pass_3);
                            break;
                        case 9:
                            Console.Write("Please enter your email: ");
                            string s_email = Console.ReadLine();
                            validation.sample_Email(s_email);
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Plese Choose Choice");
                }
             } while (choice != 0);
        }   
    }
}