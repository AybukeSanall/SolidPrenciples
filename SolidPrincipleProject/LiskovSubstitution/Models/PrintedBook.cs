using SolidPrincipleProject.SingleResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.LiskovSubstitution.Models
{
    public class PrintedBook:Book
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}
