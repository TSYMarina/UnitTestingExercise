using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3, 6)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-10, -2, 5, -7)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var addTest = new UnitTestMethods();
            //Act
            var actual = addTest.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,8)]
        [InlineData(-8, -2, -10)]
        [InlineData(0, 0, 0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var substTest = new UnitTestMethods();
            //Act
            var actual = substTest.Substract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, 3, -6)]
        [InlineData(0, 0, 0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multTest = new UnitTestMethods();
            //Act
            var actual = multTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,2)]
        [InlineData(-10, 5, -2)]
        [InlineData(0, 0, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divTest = new UnitTestMethods();
            //Act
            var actual = divTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void GetGreatDay()
        {
            //Arrange
            var byeTest = new UnitTestMethods();

            //Act
            var actual = byeTest.GetGreatDay();
            //Assert
            Assert.Matches("Have a great day!", actual);
        }

    }
}
