using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProgrammingTask.Models
{
    public class CalculationLog
    {
        [Key]
        public int CalculationLogId { get; set; }
        [NotNull]
        public string Comment { get; set; }
        [NotNull]
        public DateTime TimeStamp { get; set; }
        public List<CalculationItem> CalculationItems { get; set; }
    }
}
