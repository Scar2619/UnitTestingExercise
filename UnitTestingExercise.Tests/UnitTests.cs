using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]//Add test data <-------
        [InlineData(4, 5, 2, 11)]
        [InlineData(10, 0, 33, 43)]
        [InlineData(22, 15, 0, 37)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            Calculator calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = calculator.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(22, 15, 7)]//Add test data <-------
        [InlineData(15, 6, 9)]
        [InlineData(10, 0, 10)]
        [InlineData(100, 50, 50)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.SubtractTest(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 4, 8)]//Add test data <-------
        [InlineData(4, 8, 32)]
        [InlineData(2, 6, 12)]
        [InlineData(12, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.MultiplyTest(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(12, 6, 2)]//Add test data <-------
        [InlineData(15, 3, 5)]
        [InlineData(20, 4, 5)]
        [InlineData(22, 2, 11)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.DivideTest(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
