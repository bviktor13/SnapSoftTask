using Microsoft.AspNetCore.Mvc;
using ProgrammingTask.Models;
using ProgrammingTask.Services.Interfaces;

namespace ToDoApp.Controllers
{
    [Route("api/history")]
    [ApiController]
    public class CalculationLogController : ControllerBase
    {
        private readonly ICalculationLogService _calculationLogService;

        public CalculationLogController(ICalculationLogService calculationLogService)
        {
            _calculationLogService = calculationLogService;
        }

        [HttpGet]
        public ActionResult<List<CalculationLog>> GetLogs(string? comment)
        {
            return _calculationLogService.GetLogs(comment);
        }
    }
}