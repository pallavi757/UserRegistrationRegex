using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserValidationCustomException:Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NameEmpty,
            NameLessThanMinChar,
            NameShouldStartWithUpper,
            EmailEmpty,
            EmailLessThanMinChar,
            EmailContainNumber,
            EmailContainsSpecialChar,
            EmailContainAtSymbol,
            MobileNumberEmpty,
            MobileNumberAtleastTenDigit,
            MobileNumberContainsChar,
            PasswordEmpty,
            PasswordMinEightChar,
            PasswordAtLeastOneUpperCase,
            PasswordAtLeastOneNumber,
            PasswordOneSpecialChar,
        }
        public UserValidationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
