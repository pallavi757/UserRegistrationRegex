using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class Validation
    {
        public Regex FirstName = new Regex(@"^[A-Z a-z]{3,}$");
        public Regex LastName = new Regex(@"^[A-Z a-z]{2,}$");
        public Regex Email= new Regex(@"^[a-zA-Z0-9+_-]+([.][a-zA-Z0-9+_-]+)*@[a-zA-Z0-9]+([.][a-zA-Z0-9+_-]+)+$");
        public Regex Mobile =new Regex(@"^[0-9]{2}[\\s][0-9]{10}$");
	

        public void firstname(string firstname)

        {
            Console.WriteLine("Your first name is:" + firstname);
            if (FirstName.IsMatch(firstname))
            {
                Console.WriteLine(" entry is valid");
            }
            else
            {
                Console.WriteLine("entry is invalid");
            }
        }
        public void lastname(string lastname)

        {
            Console.WriteLine("Your last name is:" + lastname);
            if (LastName.IsMatch(lastname))
            {
                Console.WriteLine(" entry is valid");
            }
            else
            {
                Console.WriteLine("entry is invalid");
            }
        }
        public void email(string email)

        {
            Console.WriteLine("Your Email is:" + email);
            if (Email.IsMatch(email))
            {
                Console.WriteLine(" entry is valid");
            }
            else
            {
                Console.WriteLine("entry is invalid");
            }
        }
        public void mobile(string MobileNo)
        {

            if (Mobile.IsMatch(MobileNo))
            {
                Console.WriteLine(" entry is valid");
            }
            else
            {
                Console.WriteLine("entry is invalid");
            }
        }

    }
}
