namespace FizzBuzzKata2
{
    public static class FizzBuzzCalculator
    {
        public static string Print(int i)
        {
            if (i % 3 == 0)
            {
                return "Fizz";
            }
            
            return "Buzz";
        }
    }
}