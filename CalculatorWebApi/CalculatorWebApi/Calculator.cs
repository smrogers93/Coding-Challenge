using System;
using System.Collections.Generic;

namespace CalculatorWebApi
{
    public class Calculator : ICalculator
    {
        public int AddOrDivide(string option, int firstNumber, int secondNumber)
        {
            if (option == "add")
            {
                return firstNumber + secondNumber;
            }

            else
            {
                return firstNumber / secondNumber;
            }
        }

        public List<string> AvailableOperations()
        {
            return new List<string> { "Add Or Divide" };
        }
    }
}
