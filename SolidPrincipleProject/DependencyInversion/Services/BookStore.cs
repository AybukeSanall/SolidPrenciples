using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.DependencyInversion.Services
{
    public class BookStore
    {
        private readonly IBookPricingCalculator _bookPricingCalculator;
        public BookStore(IBookPricingCalculator bookPricingCalculator)
        {
            _bookPricingCalculator = bookPricingCalculator;
        }

        public decimal CalculateTotalPrice(decimal basePrice)
        {
            
            return _bookPricingCalculator.CalculatePrice(basePrice);
        }
    }
}
