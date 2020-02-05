using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-10, -15, -100, -125)]
        [InlineData(-10, 1, 2, -7)]
        public void AddTester(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var result = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(10, 5, 5)]
        [InlineData(-10, -1, -9)]
        public void SubtractTester(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var result = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-10, -1, 10)]
        [InlineData(5, -2, -10)]
        public void MultiplyTester(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var result = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(result, expected);

        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-10, 5, -2)]
        [InlineData(-10, -2, 5)]
        public void DivideTester(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var result = test.Divide(num1, num2);

            //Assert
            Assert.Equal(result, expected);

        }

        [Fact]
        public void GorillaBeatsBearTester()
        {
            //Arrange
            var test = new UnitTestMethods();

            var expected = true;

            //Act
            var result = test.GorillaBeatsBear();

            //Assert
            Assert.Equal(result, expected);

        }

        [Fact]
        public void MultipleBy0Tester()
        {
            //Arrange
            var test = new UnitTestMethods();

            var expected = 0;
            //Act
            var result = test.MultiplyBy0();

            //Assert
            Assert.Equal(result, expected);
        }
    }
}

