using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.DependencyInversion.Services
{
    public interface IBookPricingCalculator
    {
        decimal CalculatePrice(decimal basePrice);
    }
}
