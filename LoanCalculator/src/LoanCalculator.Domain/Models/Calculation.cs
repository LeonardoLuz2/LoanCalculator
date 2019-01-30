
namespace LoanCalculator.Domain.Models
{
    public class Calculation
    {
        public decimal Amount { get; set; }
        public double Rate { get; set; }
        public int Years { get; set; }
    }
}
