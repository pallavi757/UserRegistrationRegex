using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Rgestration
    {
        public Regex FirstName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex LastName = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex Email = new Regex(@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        public Regex Mobile = new Regex(@"^[0-9]{2}[\s][0-9]{10}$");
        public Regex Password = new Regex(@"^[A-Za-z]{8,}$");
        public Regex Password_Uppercase = new Regex(@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
        public Regex Password_OneNum = new Regex(@"^[A-Za-z 0-9]{1,}[A-Z]{1,}[A-Za-z 0-9]*$");
        public Regex Password_Special_Char = new Regex("[A-Z][0-9][!@#$%^&*()_+=-]{1}[a-zA-Z0-9!@#$%^&*()_+=-]{8,}$");

        public void firstname(string firstName)

        {
            Console.WriteLine("Your first name is:" + firstName);
            if (FirstName.IsMatch(firstName))
            {              
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
        }
        public void lastname(string lastName)

        {
            Console.WriteLine("Your last name is:" + lastName);
            if (LastName.IsMatch(lastName))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Last Name is Invalid");
            }
        }
        public void email(string email)

        {
            Console.WriteLine("Your Email is:" + email);
            if (Email.IsMatch(email))
            {
                Console.WriteLine(" Email is valid");
            }
            else
            {
                Console.WriteLine("Email is Invalid");
            }
        }
        public void mobile(string MobileNo)
        {

            if (Mobile.IsMatch(MobileNo))
            {
                Console.WriteLine(" Mobile is valid");
            }
            else
            {
                Console.WriteLine("Mobile is Invalid");
            }
        }
        public void password(string pass)
        {

            if (Password.IsMatch(pass))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is Invalid");
            }
        }
        public void password_Uppercase(string pass_1)
        {

            if (Password.IsMatch(pass_1))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is Invalid");
            }
        }
        public void password_OneNum(string pass_2)
        {

            if (Password_OneNum.IsMatch(pass_2))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is Invalid");
            }
        }
        public void password_Special_Char(string pass_3)
        {

            if (Password_Special_Char.IsMatch(pass_3))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is Invalid");
            }
        }
        

    }
}

