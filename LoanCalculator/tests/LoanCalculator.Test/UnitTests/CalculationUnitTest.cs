using LoanCalculator.Domain.Models;
using LoanCalculator.Domain.Services;
using LoanCalculator.Domain.Services.Interfaces;
using Xunit;

namespace LoanCalculator.Test.UnitTests
{
    public class CalculationUnitTest
    {
        private ICalculationService _calculationService;

        public CalculationUnitTest()
        {
            _calculationService = new CalculationService();
        }

        [Fact]
        public void CalculationTest()
        {
            // Arrange
            var calc = new Calculation { Amount = 10000, Rate = 5, Years = 1 };

            // Act
            var result = _calculationService.Calculate(calc);

            // Assert
            Assert.Equal(856, result, 0);
        }
    }
}
