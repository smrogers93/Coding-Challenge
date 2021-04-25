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

        public string AvailableOperations()
        {
            return "Add Or Divide";
        }
    }
}
