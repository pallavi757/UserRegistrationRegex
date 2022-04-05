using NUnit.Framework;
using UserRegistration;

namespace UserRegistrationTest
{
   
    public class Tests
    {
        Validation validation;
        [SetUp]
        public void Setup()
        {
          validation = new Validation();
        }

        /// <summary>
        /// TC-1 First Name test
        /// </summary>
        /// <param name="firstName"></param>
        [TestCase("Pallavi")]
        [TestCase("Pal")]

        public void FirstName_Expecting_ThrowCustomException(string firstName)
        {
            try
            {
                string actual = validation.ValidFirstName(firstName);

            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("FirstName is not valid", exception.Message);
            }
        }
        /// <summary>
        /// TC-2 Last Name Test
        /// </summary>
        /// <param name="lastName"></param>

        [TestCase("Kinekar")]
        [TestCase("Kin")]

        public void LastName_Expecting_ThrowCustomException(string lastName)
        {
            try
            {
                string actual = validation.ValidLastName(lastName);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("LastName is not valid", exception.Message);
            }
        }
        /// <summary>
        /// TC- Email id Test
        /// </summary>
        /// <param name="emailId"></param>

        [TestCase("Pk.kinekar122@gmail.com")]
        [TestCase("pskinekar@gmail.com")]

        public void EmailId_Expecting_ThroCustomExeption(string email)
        {
            try
            {
                string actual = validation.ValidEmailId(email);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("EmailID is not valid", exception.Message);
            }
        }
        /// <summary>
        /// TC -Mobile number test
        /// </summary>
        /// <param name="MobileNumber"></param>

        [TestCase("91 7745239933")]
        [TestCase("917747239833")]

        public void MobileNumber_Expecting_ThroCustomExeption(string MobileNo)
        {
            try
            {
                string actual = validation.ValidMobileNumber(MobileNo);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("MobileNumber is not valid", exception.Message);
            }
        }

        [TestCase("Kinekarpallavi")]
        [TestCase("123Kinekar")]
        public void Password_EightChar_Expecting_ThroCustomExeption(string pass)
        {
            try
            {
                string actual = validation.ValidPasswordMinEightChar(pass);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("Password is not valid", exception.Message);
            }
        }
        /// <summary>
        /// TC- Password use One Upper case
        /// </summary>
        /// <param name="PasswordOneUpperCase"></param>

        [TestCase("Pallavisk")]
        [TestCase("Pskinekar")] 
        public void Password_OneUpperCase_Expecting_ThroCustomExeption(string pass_1)
        {
            try
            {
                string actual = validation.ValidPasswordAtLeastOneUpperCase(pass_1);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("Password is not valid", exception.Message);
            }
        }
        /// <summary>
        /// TC - Passsword use one number
        /// </summary>
        /// <param name="PasswordUseOneNumber"></param>


        [TestCase("Pallavisk2")]
        [TestCase("Pskinekar")]
        public void Password_OneNubmer_Expecting_ThroCustomExeption(string pass_2)
        {
            try
            {
                string actual = validation.ValidPasswordAtLeastOneNumber(pass_2);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("Password is not valid", exception.Message);
            }
        }
        /// <summary>
        /// TC- Pawword use one special char
        /// </summary>
        /// <param name="PasswordUseOneSpecialChar"></param>

        [TestCase("Palla@76")]
        [TestCase("PallSk45")]
        public void Password_AtleastOneSpecialChar_Expecting_ThroCustomExeption(string pass_3)
        {
            try
            {
                string actual = validation.ValidPasswordOneSpecialChar(pass_3);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("Password is not valid", exception.Message);
            }
        }
    }
}