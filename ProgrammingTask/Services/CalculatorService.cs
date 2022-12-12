using ProgrammingTask.Helpers.ExtensionMethods;
using ProgrammingTask.Models;
using ProgrammingTask.Services.Interfaces;

namespace ProgrammingTask.BL
{
	/// <summary>
	/// Calculates 
	/// </summary>
    public class CalculatorService : ICalculatorService
    {
		private readonly ICalculationLogService _calculationLogService;

        public CalculatorService(ICalculationLogService calculationLogService)
        {
			_calculationLogService = calculationLogService;
		}
		/// <summary>
		/// My implementation of product calculation
		/// </summary>
		/// <param name="numbers"></param>
		/// <returns></returns>
		public int[] ProductCalculation(int[] numbers, string comment)
		{
			int[] result = new int[numbers.Length];

			if (numbers.IsNullOrEmpty())
            {
				throw new ArgumentNullException(nameof(numbers));
            }

			for (int i = 0; i < numbers.Length; i++)
			{
				int product = 1;

				for (int j = 0; j < numbers.Length; j++)
				{
					if (i == j)
					{
						continue;
					}

					product = product * numbers[j];
				}

				result[i] = product;
			}

			Log(numbers, comment);

			return result;
		}

		/// <summary>
		/// Product calculation in linear without using division operator.
		/// </summary>
		/// <param name="numbers"></param>
		/// <returns></returns>
		public int[] ProductCalculationInLinearWithoutDivision(int[] numbers, string comment)
		{
			int[] result = new int[numbers.Length];

			if (numbers.IsNullOrEmpty())
			{
				throw new ArgumentNullException(nameof(numbers));
			}

			int left = 1;
			int right = 1;

			result[0] = 1;
			for (int i = 1; i < result.Length; i++)
			{
				left = left * numbers[i - 1];
				result[i] = left;
			}

			for (int i = result.Length - 2; i >= 0; i--)
			{
				right = right * numbers[i + 1];
				result[i] = result[i] * right;
			}

			Log(numbers, comment);

			return result;
		}

		private void Log(int[] numbers, string comment)
		{
			_calculationLogService.Log(new CalculationLog()
			{
				Comment = comment,
				TimeStamp = DateTime.Now,
				CalculationItems = numbers.Select(x => new CalculationItem()
				{
					Value = x
				}).ToList(),
			});
		}
	}
}
