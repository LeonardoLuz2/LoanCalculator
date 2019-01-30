using LoanCalculator.Domain.Models;
using LoanCalculator.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoanCalculator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private readonly ICalculationService _calculationService;

        public CalculationController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(decimal))]
        [ProducesResponseType(400, Type = typeof(void))]
        public IActionResult Calculate([FromBody] Calculation calculation)
        {
            return Ok(_calculationService.Calculate(calculation));
        }
    }
}