using Microsoft.AspNetCore.Mvc;
using ProgrammingTask.Models;
using ProgrammingTask.Services.Interfaces;

namespace ToDoApp.Controllers
{
    [Route("api/calculate")]
    [ApiController]
    public class ProductCalculationController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;
        private readonly ICalculationLogService _calculationLogService;

        public ProductCalculationController(
            ICalculatorService calculatorService,
            ICalculationLogService calculationLogService)
        {
            _calculatorService = calculatorService;
            _calculationLogService = calculationLogService;
        }

        [HttpPost]
        [Route("a")]
        public async Task<ActionResult<int[]>> MyProductCalculation(int[] numbers, string comment)
        {
            return Ok(_calculatorService.ProductCalculation(numbers, comment));
        }

        [HttpPost]
        [Route("b")]
        public ActionResult<int[]> ProductCalculationWithoutDivisionOperator(int[] numbers, string comment)
        {
            return Ok(_calculatorService.ProductCalculationInLinearWithoutDivision(numbers, comment));
        }

        [HttpPost]
        [Route("c")]
        public ActionResult<int[]> ProductCalculationInLinearWithoutDivisionOperator(int[] numbers, string comment)
        {
            return Ok(_calculatorService.ProductCalculationInLinearWithoutDivision(numbers, comment));
        }
    }
}