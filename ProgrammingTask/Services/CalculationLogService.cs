using Microsoft.EntityFrameworkCore;
using ProgrammingTask.Data;
using ProgrammingTask.Models;
using ProgrammingTask.Services.Interfaces;

namespace ProgrammingTask.Services
{
    public class CalculationLogService : ICalculationLogService
    {
        private readonly DataContext _context;

        public CalculationLogService(DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Saves product calculation values to database
        /// </summary>
        /// <param name="calculationLog"></param>
        public void Log(CalculationLog calculationLog)
        {
            _context.CalculationLogs.Add(calculationLog);
            _context.SaveChanges();
        }

        /// <summary>
        /// Get product calculation values from database
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public List<CalculationLog> GetLogs(string comment)
        {
            if(string.IsNullOrEmpty(comment))
            {               
                return _context.CalculationLogs.Include(x => x.CalculationItems).ToList();
            }

            return  _context.CalculationLogs.Include(x => x.CalculationItems).Where(c => c.Comment == comment).ToList();
        }
    }
}
