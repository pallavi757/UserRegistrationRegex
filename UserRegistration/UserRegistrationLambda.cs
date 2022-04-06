using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegistrationLambda
    {
        string FirstName = (@"^[A-Z][A-Za-z]{2,}$");
        string LastName = (@"^[A-Z][A-Za-z]{2,}$");
        string Email = (@"^[A-Za-z]+([.+-][A-Za-z 0-9]+)*@[A-Za-z 0-9]+.[A-Za-z]([.[A-Za-z]{2,})?$");
        string Mobile = (@"^[0-9]{2}[\s][0-9]{10}$");
        string Password = (@"^[A-Za-z]{8,}$");
        string Password_Uppercase = (@"^[A-Za-z]*[A-Z]{1,}[A-Za-z]*$");
        string Password_OneNum = (@"^[A-Za-z 0-9]{1,}[A-Z]{1,}[A-Za-z 0-9]*$");
        string Password_Special_Char = (@"^(?=[a-zA-Z0-9#@$?]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");
        public string ValidFirstName(string firstName)
        {
            bool FirstNamePattern(string FirstNamePattern) => Regex.IsMatch(FirstNamePattern, firstName);
            Regex regex = new Regex(FirstName);
            var result = regex.Match(FirstName);
            //bool result = FirstNamePattern(firstName);
            try
            {
                if (!result.Success)
                {
                    if (firstName.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameEmpty,
                            "First name should not be empty");
                    else if (firstName.Length < 3)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameLessThanMinChar,
                            "First name should contain atleast three character");
                    else if (!char.IsUpper(firstName[0]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameShouldStartWithUpper,
                            "First name should start with upper case");
                }
                else
                {
                    return "First Name is Valid";
                }
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "First Name is Invalid";
        }
        public string ValidLastName(string lastName)
        {
            bool LastNamePattern(string LastNamePattern) => Regex.IsMatch(LastNamePattern,lastName);
            Regex regex = new Regex(LastName);
            var result = regex.Match(lastName);
            try
            {
                if (!result.Success)
                {
                    if (lastName.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameEmpty,
                            "Last name should not be empty");
                    else if (lastName.Length < 3)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameLessThanMinChar,
                            "Last name should contain atleast three character");
                    else if (!char.IsUpper(lastName[0]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.NameShouldStartWithUpper,
                            "Last name should start with upper case");
                }
                else
                {
                    return "Last Name is Valid";
                }
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Last Name is Invalid";
        }

        public string ValidEmailId(string email)
        {
            bool EmailPattern(string EmailPattern) => Regex.IsMatch(EmailPattern, email);
            Regex regex = new Regex(Email);
            var result = regex.Match(email);
            try
            {
                if (!result.Success)
                {
                    if (email.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailEmpty,
                            "Email should not be empty");
                    else if (email.Length < 7)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailLessThanMinChar,
                            "Email should contain atleast seven character");
                    else if (!email.Any(char.IsDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailContainNumber,
                            "Email should contain atleast one number");
                    else if (!email.Any(char.IsLetterOrDigit))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailContainsSpecialChar,
                            "Email should contain special characters");
                    else if (!email.Contains('@'))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.EmailContainAtSymbol,
                            "Email should contains @ Symbol");
                }
                else return "Email is valid";
            }
            catch (UserValidationCustomException exception)
            {

                throw exception;
            }
            return "Email is Invalid";
        }

        public string ValidMobileNumber(string MobileNo)
        {
            bool MobilePattern(string MobilePattern) => Regex.IsMatch(MobilePattern,MobileNo);
            Regex regex = new Regex(Mobile);
            var result = regex.Match(MobileNo);
            try
            {
                if (!result.Success)
                {
                    if (MobileNo.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.MobileNumberEmpty,
                            "Mobile number should not be empty");
                    else if (MobileNo.Length < 10)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.MobileNumberAtleastTenDigit,
                            "Mobile number should contain atleast ten digits");
                    else if (MobileNo.Contains(' '))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.MobileNumberContainsChar,
                            "Mobile number should not contain characters");
                }
                else return "Mobile Number is valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Mobile number is Invalid";
        }

        public string ValidPasswordMinEightChar(string pass)
        {
            bool PasswordMinEightCharPattern(string PasswordMinEightCharPattern) => Regex.IsMatch(PasswordMinEightCharPattern, pass);
            Regex regex = new Regex(Password);
            var result = regex.Match(pass);
            try
            {
                if (!result.Success)
                {
                    if (pass.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordEmpty,
                            "Password should not be empty");
                    else if (pass.Length < 8)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordMinEightChar,
                            "Password should contain atleast eight characters");
                }
                else return "Password is valid";
            }

            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }
        public string ValidPasswordAtLeastOneUpperCase(string pass_1)
        {
            bool PasswordAtLeastOneUpperCasePattern(string PasswordAtLeastOneUpperCasePattern) => Regex.IsMatch(PasswordAtLeastOneUpperCasePattern, pass_1);
            Regex regex = new Regex(Password_Uppercase);
            var result = regex.Match(pass_1);
            try
            {
                if (!result.Success)
                {
                    if (!char.IsUpper(pass_1[1]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordAtLeastOneUpperCase,
                            "Password should contain atleast one upper case character");
                }
                else return "Password is valid";
            }

            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }

        public string ValidPasswordAtLeastOneNumber(string pass_2)
        {
            bool PasswordAtLeastOneNumberPattern(string PasswordAtLeastOneNumberPattern) => Regex.IsMatch(PasswordAtLeastOneNumberPattern, pass_2);
            Regex regex = new Regex(Password_OneNum);
            var result = regex.Match(pass_2);
            try
            {
                if (!result.Success)
                {
                    if (!char.IsUpper(pass_2[1]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordAtLeastOneNumber,
                            "Password should contain atleast one Digit");
                }
                else return "Password is valid";
            }

            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";
        }

        public string ValidPasswordOneSpecialChar(string pass_3)
        {
            bool PasswordOneSpecialCharPattern(string PasswordOneSpecialCharPattern) => Regex.IsMatch(PasswordOneSpecialCharPattern, pass_3);
            Regex regex = new Regex(Password_Special_Char);
            var result = regex.Match(pass_3);
            try
            {
                if (!result.Success)
                {
                    if (!char.IsUpper(pass_3[1]))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.PasswordOneSpecialChar,
                            "Password should contain atleast one special character");
                }
                else return "Password is valid";
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "Password is Invalid";

        }
    }
}
