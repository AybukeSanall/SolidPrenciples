using SolidPrincipleProject.SingleResponsiblityPrenciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.OpenColosedPrenciple.Services
{
    public abstract class DiscountCalculator
    {
       public abstract decimal DiscountCalculate(Book book);
    }
}
