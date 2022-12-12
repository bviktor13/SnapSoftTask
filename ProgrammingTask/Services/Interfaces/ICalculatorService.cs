namespace ProgrammingTask.Services.Interfaces
{
    public interface ICalculatorService
    {
        int[] ProductCalculation(int[] numbers, string comment);
        int[] ProductCalculationInLinearWithoutDivision(int[] numbers, string comment);
    }
}
