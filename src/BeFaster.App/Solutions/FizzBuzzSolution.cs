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

        public static bool IsFizzDeluxe(int number)
        {
            return number % 3 == 0 && number.ToString().Contains("3");
        }

        public static bool IsBuzzDeluxe(int number)
        {
            return number % 5 == 0 && number.ToString().Contains("5");
        }

        public static string FizzBuzz(int number)
        {
            bool isFizz = IsFizz(number), isBuzz = IsBuzz(number), isFizzDeluxe = IsFizzDeluxe(number), isBuzzDeluxe = IsBuzzDeluxe(number);
            var result = number.ToString();
            if (isFizz && isBuzz)
            {
                result = "fizz buzz";
                if (isFizzDeluxe && isBuzzDeluxe)
                {
                    result += " " + (number % 2 == 0 ? "deluxe" : "fake deluxe");
                }
            }
            else if (isFizz)
            {
                result = "fizz";
                if (isFizzDeluxe)
                {
                    result += " " + (number % 2 == 0 ? "deluxe" : "fake deluxe");
                }
            }
            else if (isBuzz)
            {
                result = "buzz";
                if (isBuzzDeluxe)
                {
                    result += " " + (number % 2 == 0 ? "deluxe" : "fake deluxe");
                }
            }
            return result;
        }
    }
}
