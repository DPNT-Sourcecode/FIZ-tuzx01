﻿using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions
{
    public static class HelloSolution
    {
        public static string Hello(string friendName)
        {
            return $"Hello, {friendName}!";
            //throw new SolutionNotImplementedException();
        }
    }
}
