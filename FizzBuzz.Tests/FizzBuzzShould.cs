using System;
using FizzBuzzKata2;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzShould
    {
        [Fact]
        public void ReturnFizzIfInputIs3()
        {
            string expected = "Fizz";

            string actual = FizzBuzzCalculator.Print(3);
            
            Assert.Equal(expected,actual);
        }
        
        [Fact]
        public void ReturnFizzIfInputIs6()
        {
            string expected = "Fizz";

            string actual = FizzBuzzCalculator.Print(6);
            
            Assert.Equal(expected,actual);
        }

    }
}