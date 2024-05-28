using ConsoleApp1;

namespace XUnitProject
{
    public class UnitTest1
    {
        [Fact] //A test marked with the Fact attribute represents a single test case.
        public void Test_ValidateEmail_Method()
        {
            var mailManager = new MailManager();
            const string mailAddress = "test@test.test";

            bool isValid = mailManager.IsValidAddress(mailAddress);

            //Assert
            Assert.True(isValid, $"The email {mailAddress} is not valid");
        }

        //Multiple Test + Test With Parameters :
        [Theory] // The Theory attribute is used to define a parametrized test. It allows testing multiple inputs against the same test logic.
        [InlineData(2, 3, 15)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 1, 0)]
        public void Test_Add_Method(int a, int b, int expected)
        {
            var calculator = new Calculator();
            var result = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}