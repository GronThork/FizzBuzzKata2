using System;
using FizzBuzzKata2;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void ReturnFizzForMultipleOf3(int i)
        {
            var expected = "Fizz";

            var actual = FizzBuzzCalculator.Print(i);
            
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void ReturnBuzzForMultipleOf5(int i)
        {
            var expected = "Buzz";

            var actual = FizzBuzzCalculator.Print(i);
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ReturnBuzzIfInputIs5()
        {
            string expected = "Buzz";

            string actual = FizzBuzzCalculator.Print(5);
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ReturnFizzBuzzIfInputIs30()
        {
            string expected = "FizzBuzz";

            string actual = FizzBuzzCalculator.Print(30);
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ReturnFizzBuzzIfInputIs60()
        {
            string expected = "FizzBuzz";

            string actual = FizzBuzzCalculator.Print(60);
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ReturnFizzBuzzIfInputIs90()
        {
            string expected = "FizzBuzz";

            string actual = FizzBuzzCalculator.Print(90);
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ReturnTheInputIfInputIs1()
        {
            var expected = "1";

            var actual = FizzBuzzCalculator.Print(1);
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ReturnBuzzIfInputIs10()
        {
            var expected = "Buzz";

            var actual = FizzBuzzCalculator.Print(10);
            
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void ReturnBuzzIfInputIs20()
        {
            var expected = "Buzz";

            var actual = FizzBuzzCalculator.Print(20);
            
            Assert.Equal(expected,actual);
        }

    }
}