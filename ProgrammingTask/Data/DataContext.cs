using Microsoft.EntityFrameworkCore;
using ProgrammingTask.Models;

namespace ProgrammingTask.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<CalculationLog> CalculationLogs { get; set; }
    }
}
