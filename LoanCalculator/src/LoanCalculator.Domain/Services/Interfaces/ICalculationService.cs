using LoanCalculator.Domain.Models;

namespace LoanCalculator.Domain.Services.Interfaces
{
    public interface ICalculationService
    {
        decimal Calculate(Calculation calculation);
    }
}
