using ProgrammingTask.Models;

namespace ProgrammingTask.Services.Interfaces
{
    public interface ICalculationLogService
    {
        void Log(CalculationLog calculationLog);

        List<CalculationLog> GetLogs(string comment);
    }
}
