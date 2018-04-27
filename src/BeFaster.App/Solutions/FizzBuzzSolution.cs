using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var result = number.ToString();
            if (number % 3 == 0 && number % 5 == 0)
                result = "fizz buzz";
            else if (number % 3 == 0)
                result = "fizz";
            else if (number % 5 == 0)
                result = "buzz";
            return result;
        }
    }
}
