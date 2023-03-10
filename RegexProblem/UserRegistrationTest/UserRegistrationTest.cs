using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexProblem;
namespace UserRegistrationTest
{
    [TestClass]
    public class UserRegistrationTest
    {
        RegexValidation validation = new RegexValidation();
        SampleEmails checkemails = new SampleEmails();
        [TestMethod]
        public void ValidateFirstName_Should_return_true_on_valid_input()
        {
            //Arrange
            bool expected = true;//"^[A-Z][a-zA-Z]{2,}$";
            //Act
            bool result = validation.ValidateFirstName("Sangmeshwar");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateFirstName_Should_return_false_on_invalid_input()
        {
            //Arrange
            string expected = "Sangmeshwar";
            //Act
            bool result = validation.ValidateFirstName("sangmeshwar");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void ValidateLastName_Should_return_true_on_valid_input()
        {
            //Arrange
            bool expected = true;//"^[A-Z][a-zA-Z]{2,}$";
            //Act
            bool result = validation.ValidateLastName("Patil");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateLastName_Should_return_false_on_invalid_input()
        {
            //Arrange
            string expected = "Patil";
            //Act
            bool result = validation.ValidateLastName("patil");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void ValidateEmail_Should_return_true_on_valid_input()
        {
            //Arrange
            bool expected = true;//"^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            //Act
            bool result = validation.ValidateEmail("Patil.sangmeshwar@gmail.co.in");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateEmail_Should_return_false_on_invalid_input()
        {
            //Arrange
            string expected = "Sangmeshwar09@gmail.com.in";
            //Act
            bool result = validation.ValidateEmail("Sangmeshwar09@gmail.co.in.au");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void ValidateNumber_Should_return_true_on_valid_input()
        {
            //Arrange
            bool expected = true;//@"[0-9]{1,2}\s[0-9]{10}";
            //Act
            bool result = validation.ValidatePhoneNumber("91 6958348751");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateNumber_Should_return_false_on_invalid_input()
        {
            //Arrange
            string expected = "91 6958348751";
            //Act
            bool result = validation.ValidatePhoneNumber("12548963");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void ValidatePasswordRule1_Should_return_true_on_valid_input()
        {
            //Arrange
            bool expected = true;//"[A-Z a-z 0-9]{8,}";
            //Act
            bool result = validation.ValidatePassword1("Sangmeshwar96");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidatePasswordRule1_Should_return_false_on_valid_input()
        {
            //Arrange
            string expected = "Sangmeshwar96";
            //Act
            bool result = validation.ValidatePassword1("ghgfh");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void ValidatePasswordRule2_Should_return_true_on_valid_input()
        {
            //Arrange
            bool expected = true;//"^(?=.*?[A-Z]).{8,}$";
            //Act
            bool result = validation.ValidatePassword2("Sangmeshwar96");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidatePasswordRule2_Should_return_false_on_valid_input()
        {
            //Arrange
            string expected = "Sangmeshwar96";
            //Act
            bool result = validation.ValidatePassword2("ghgfh");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void ValidatePasswordRule3_Should_return_true_on_valid_input()
        {
            //Arrange
            bool expected = true;//"^(?=.*?[A-Z])(?=.*?[0-9]).{8,}$";
            //Act
            bool result = validation.ValidatePassword3("Sangmeshwar96");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidatePasswordRule3_Should_return_false_on_valid_input()
        {
            //Arrange
            string expected = ".Sangmeshwar96";
            //Act
            bool result = validation.ValidatePassword3("ghgfh");
            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void ValidatePasswordRule4_Should_return_true_on_valid_input()
        {
            //Arrange
            bool expected = true;//"^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=-]).{8,}$";
            //Act
            bool result = validation.ValidatePassword4(".Sangmeshwar*96");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidatePasswordRule4_Should_return_false_on_valid_input()
        {
            //Arrange
            string expected = ".Sangmeshwar.96";
            //Act
            bool result = validation.ValidatePassword4("ghgfh");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [DataTestMethod]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc@yahoo.com")]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc-100@yahoo.com")]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc.100@yahoo.com")]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc111@abc.com")]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc-100@abc.net")]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc+100@gmail.com")]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc123@gmail.1a")]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc@1.com")]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc@.com.my")]
        [DataRow("^[a-zA-Z0-9]+([!@#$%^&*()_+.,-][a-zA-Z0-9]+)*[@][a-zA-Z]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$", "abc123@.com.com")]
        public void TestMultipleEmails(string expected, string email)
        {
            //Act
            string actual = checkemails.CheckEmails(email);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string expected = " ";
                //Act
                bool result = validation.ValidateFirstName("Sangmeshwar");
            }
            catch(RegexProblemCustomException e)
            {
                //Assert
                Assert.AreEqual("FirstName should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_FirstName_Should_Throw_UserRegistrationException()
        {
            try
            {
                //Arrange
                string expected = null;
                //Act
                bool result = validation.ValidateFirstName("Sangmeshwar");
            }
            catch (RegexProblemCustomException e)
            {
                //Assert
                Assert.AreEqual("FirstName should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string expected = " ";
                //Act
                bool result = validation.ValidateLastName("Patil");
            }
            catch (RegexProblemCustomException e)
            {
                //Assert
                Assert.AreEqual("LastName should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                //Arrange
                string expected = null;
                //Act
                bool result = validation.ValidateLastName("Patil");
            }
            catch (RegexProblemCustomException e)
            {
                //Assert
                Assert.AreEqual("LastName should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_Email_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string expected = " ";
                //Act
                bool result = validation.ValidateEmail("Patil.sangmeshwar@gmail.co.in");
            }
            catch (RegexProblemCustomException e)
            {
                //Assert
                Assert.AreEqual("Email should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Email_Should_Throw_UserRegistrationException()
        {
            try
            {
                //Arrange
                string expected = null;
                //Act
                bool result = validation.ValidateEmail("Patil.sangmeshwar@gmail.co.in");
            }
            catch (RegexProblemCustomException e)
            {
                //Assert
                Assert.AreEqual("Email should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_PhoneNumber_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string expected = " ";
                //Act
                bool result = validation.ValidatePhoneNumber("91 9665679388");
            }
            catch (RegexProblemCustomException e)
            {
                //Assert
                Assert.AreEqual("PhoneNumber should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_PhoneNumber_Should_Throw_UserRegistrationException()
        {
            try
            {
                //Arrange
                string expected = null;
                //Act
                bool result = validation.ValidatePhoneNumber("91 9665679388");
            }
            catch (RegexProblemCustomException e)
            {
                //Assert
                Assert.AreEqual("PhoneNumber should not be null", e.Message);
            }
        }
    }
}