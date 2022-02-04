using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(6, -6, 7, 7)]
        [InlineData(8, 9, 10, 27)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
           Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 4, 1)]//Add test data <-------
        [InlineData(6, 10, -4)]
        [InlineData(8, 2, 6)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtract = new Calculator();

            //Act
            var actual = subtract.Subtract(minuend , subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 25)]//Add test data <-------
        [InlineData(-2, -4, 8)]
        [InlineData(4, 5, 20)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiply = new Calculator();
            //Act
            var actual = multiply.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 1)]//Add test data <-------
        [InlineData(20, 4, 5)]
        [InlineData(100, -2, -50)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new Calculator();
            //Act
            var actual = divide.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
