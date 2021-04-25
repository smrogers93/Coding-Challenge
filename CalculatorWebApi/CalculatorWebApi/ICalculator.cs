using System;
using System.Collections.Generic;

namespace CalculatorWebApi
{
    public interface ICalculator
    {
        List<string> AvailableOperations();
        int AddOrDivide(string option, int firstNumber, int secondNumber);
    }
}
