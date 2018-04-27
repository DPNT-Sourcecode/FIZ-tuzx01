using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class FizzBuzzSolution
    {
        public static bool IsFizz(int number)
        {
            return number % 3 == 0 || number.ToString().Contains("3");
        }

        public static bool IsBuzz(int number)
        {
            return number % 5 == 0 || number.ToString().Contains("5");
        }

        public static string FizzBuzz(int number)
        {
            bool isFizz = IsFizz(number), isBuzz = IsBuzz(number);
            var result = number.ToString();
            if (isFizz && isBuzz)
                result = "fizz buzz";
            else if (isFizz)
                result = "fizz";
            else if (isBuzz)
                result = "buzz";
            return result;
        }
    }
}
