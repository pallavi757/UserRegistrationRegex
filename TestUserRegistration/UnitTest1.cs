using NUnit.Framework;
using System;
using UserRegistration;

namespace TestUserRegistration
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
            string expected = "first Name is Valid";
            string name = " ";
            string result = validation.Validfirstname(name);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ValidLastName()
        {
            string expected = "Last Name is Valid";
            string last = " ";
            string result = validation.Validlastname(last);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidEmail()
        {
            string expected = "Email is Valid";
            string result = null;
            string email = "pallavikinekar.111@something.com";
            try
            {
                result = validation.email(email);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPhone()
        {
            string expected = "Phone number is Valid";
            string? result = null;
            try
            {
                string mobile = "0234567893";
                result = validation.mobile(mobile);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPassword()
        {
            string res = null;
            string expected = "Password should contain atleast eight characters";
            try
            {
                string password = "passwords";
                res = validation.password(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, res);
            }
        }
    }
}