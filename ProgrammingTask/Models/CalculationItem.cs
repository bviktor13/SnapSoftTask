using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammingTask.Models
{
    public class CalculationItem
    {
        public int Id { get; set; }

        public int Value { get; set; }
        public int CalculationLogId { get; set; }
    }
}
