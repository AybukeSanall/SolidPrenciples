using SolidPrincipleProject.SingleResponsiblityPrenciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.OpenColosedPrenciple.Services
{
    public class PrintedBookDiscountCalculator : DiscountCalculator
    {
        public override decimal DiscountCalculate(Book book)
        {
            if (!book.IsEBook)
            {
                return book.Price * 0.05m; 
            }
            else
            {
                return 0m;
            }
        }
    }
}
