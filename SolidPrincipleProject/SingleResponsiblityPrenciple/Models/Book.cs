using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.SingleResponsiblityPrenciple.Models
{
    public class Book:Base
    {
        public string?  Name { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public int? PageCount { get; set; }
        public string? Language { get; set; }

    }
}
