using FluentValidation;
using LoanCalculator.Domain.Models;
using LoanCalculator.Domain.Services;
using LoanCalculator.Domain.Services.Interfaces;
using LoanCalculator.Domain.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace LoanCalculator.Api.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IValidator<Calculation>, CalculationValidator>();
            services.AddScoped<ICalculationService, CalculationService>();
        }
    }
}
