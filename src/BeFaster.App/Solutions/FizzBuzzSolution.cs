using BeFaster.Runner.Exceptions;
using System.Linq;

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

        public static bool IsDeluxe(int number)
        {
            return number > 10 && number.ToString().Distinct().Count() == 1;
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
            if (IsDeluxe(number))
            {
                if (!isFizz && !isBuzz)
                    result = "deluxe";
                else
                    result += " deluxe";
            }
            return result;
        }
    }
}
