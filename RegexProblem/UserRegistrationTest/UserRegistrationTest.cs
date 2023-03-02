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
    }
}