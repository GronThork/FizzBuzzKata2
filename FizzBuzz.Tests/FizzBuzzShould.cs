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

        [Theory]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(90)]
        public void ReturnFizzBuzzForMultiplesOf3And5(int i)
        {
            var expected = "FizzBuzz";

            var actual = FizzBuzzCalculator.Print(i);
            
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void ReturnTheInputIfInputIs1()
        {
            var expected = "1";

            var actual = FizzBuzzCalculator.Print(1);
            
            Assert.Equal(expected,actual);
        }
    }
}