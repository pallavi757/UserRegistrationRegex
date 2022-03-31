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
                Console.WriteLine("Enter 0 for Exit");

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