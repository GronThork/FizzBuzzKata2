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

    }
}