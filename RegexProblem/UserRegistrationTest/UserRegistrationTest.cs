using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexProblem;
namespace UserRegistrationTest
{
    [TestClass]
    public class UserRegistrationTest
    {
        RegexValidation validation = new RegexValidation();
        [TestMethod]
        public void ValidateFirstName_Should_return_true_on_valid_input()
        {
            //Arrange
            string expected = "^[A-Z][a-zA-Z]{2,}$";
            //Act
            string result = validation.ValidateFirstName("Sangmeshwar");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateFirstName_Should_return_false_on_invalid_input()
        {
            //Arrange
            string expected = "Sangmeshwar";
            //Act
            string result = validation.ValidateFirstName("sangmeshwar");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void ValidateLastName_Should_return_true_on_valid_input()
        {
            //Arrange
            string expected = "^[A-Z][a-zA-Z]{2,}$";
            //Act
            string result = validation.ValidateLastName("Patil");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateLastName_Should_return_false_on_invalid_input()
        {
            //Arrange
            string expected = "Patil";
            //Act
            string result = validation.ValidateLastName("patil");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void ValidateEmail_Should_return_true_on_valid_input()
        {
            //Arrange
            string expected = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            //Act
            string result = validation.ValidateEmail("Sangmeshwar09@gmail.com.in");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateEmail_Should_return_false_on_invalid_input()
        {
            //Arrange
            string expected = "Sangmeshwar09@gmail.com.in";
            //Act
            string result = validation.ValidateEmail("Sangmeshwar09@gmail.co.in.au");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
        [TestMethod]
        public void ValidateNumber_Should_return_true_on_valid_input()
        {
            //Arrange
            string expected = @"[0-9]{1,2}\s[0-9]{10}";
            //Act
            string result = validation.ValidatePhoneNumber("91 6958348751");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateNumber_Should_return_false_on_invalid_input()
        {
            //Arrange
            string expected = "91 6958348751";
            //Act
            string result = validation.ValidatePhoneNumber("12548963");
            //Assert
            Assert.AreNotEqual(expected, result);
        }
    }
}