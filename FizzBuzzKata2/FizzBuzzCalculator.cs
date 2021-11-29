namespace FizzBuzzKata2
{
    public static class FizzBuzzCalculator
    {
        public static string Print(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return "FizzBuzz";
            }
            
            if (i % 3 == 0)
            {
                return "Fizz";
            }

            if (i == 5)
            {
                return "Buzz";
            }

            return i.ToString();
        }
    }
}