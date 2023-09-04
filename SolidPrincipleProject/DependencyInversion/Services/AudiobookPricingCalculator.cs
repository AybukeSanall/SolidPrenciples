using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.DependencyInversion.Services
{
    public class AudiobookPricingCalculator : IBookPricingCalculator
    {
        public decimal CalculatePrice(decimal basePrice)
        {
           return basePrice* 0.8m;
        }
    }
}
