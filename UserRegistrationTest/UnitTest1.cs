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


        [Test]

        public void ValidFirstName()
        {
            string firstName = "Pallavi";
            string result = null;
            try
            {
                string actual = validation.ValidFirstName(firstName);

            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("FirstName is not valid", exception.Message);
            }
        }
        

        [Test]

        public void ValidLastName()
        {
            string lastName = "Kinekar";
            string result = null;
            try
            {
                string actual = validation.ValidLastName(lastName);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("LastName is not valid", exception.Message);
            }
        }



        [Test]

        public void ValidEmailId()
        {
            string email = "Pk.kinekar122@gmail.com";
            string result = null;
            try
            {
                string actual = validation.ValidEmailId(email);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("EmailID is not valid", exception.Message);
            }
        }


        [Test]


        public void ValidMobileNumber()
        {
            string MobileNo = "91 7745239933";
            string result = null;
            try
            {
                string actual = validation.ValidMobileNumber(MobileNo);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("MobileNumber is not valid", exception.Message);
            }
        }

        [Test]

        public void ValidPasswordMinEightChar()
        {
            string pass = "Kinekarpallavi";
            string result = null;
            try
            {
                string actual = validation.ValidPasswordMinEightChar(pass);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("Password is not valid", exception.Message);
            }
        }


        [Test]

        public void ValidPasswordAtLeastOneUpperCase()
        {
            string pass_1 = "Pallavisk";
            string result = null;
            try
            {
                string actual = validation.ValidPasswordAtLeastOneUpperCase(pass_1);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("Password is not valid", exception.Message);
            }
        }


        [Test]

        public void ValidPasswordAtLeastOneNumber()
        {
            string pass_2 = "Pallu12Kinekar";
            string result = null;
            try
            {
                string actual = validation.ValidPasswordAtLeastOneNumber(pass_2);
            }
            catch (UserValidationCustomException exception)
            {
                Assert.AreEqual("Password is not valid", exception.Message);
            }
        }


        [Test]

        public void ValidPasswordOneSpecialChar()
        {
            string pass_3 = "Palla@763";
            string result = null;
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