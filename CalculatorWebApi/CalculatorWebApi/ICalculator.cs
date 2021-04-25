namespace CalculatorWebApi
{
    public interface ICalculator
    {
        string AvailableOperations();
        int AddOrDivide(string option, int firstNumber, int secondNumber);
    }
}
