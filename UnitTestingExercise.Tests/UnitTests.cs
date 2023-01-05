using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4,6,3,13)]
        [InlineData(64,2,-2,64)]
        [InlineData(0,0,0,0)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                int actual = calculator.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);
                
        }

        [Theory]
        [InlineData(5,1,4)]
        [InlineData(64,3,61)]
        [InlineData(32,22,10)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();
            //Act
            int actual = calculator.Subtract(minuend , subtrhend);
            //Assert
            Assert.Equal((int)expected, actual);
        }

        [Theory]
        [InlineData(3,3,9)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            Calculator calculator = new Calculator();
            //Arrange
            int acutal = calculator.Multiply(num1, num2);
            //Act
            Assert.Equal((int)expected, acutal);
            //Assert

        }

        [Theory]
        [InlineData(3,3,1)]
        [InlineData(4,24,6)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator =new Calculator();
            //Act
            int actual = calculator.Divide(num1 , num2);
            //Assert
            Assert.Equal(expected,actual);
        }

    }
}
