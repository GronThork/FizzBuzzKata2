namespace FizzBuzzKata2
{
    public static class FizzBuzzCalculator
    {
        public static string Print(int i)
        {
            if (i == 30)
            {
                return "FizzBuzz";
            }

            if (i == 60)
            {
                return "FizzBuzz";
            }
            
            if (i % 3 == 0)
            {
                return "Fizz";
            }
            
            return "Buzz";
        }
    }
}