using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.DependencyInversion.Services
{
    public class EBookPricingCalculator : IBookPricingCalculator
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice + 5.0m;
        }
    }
}
