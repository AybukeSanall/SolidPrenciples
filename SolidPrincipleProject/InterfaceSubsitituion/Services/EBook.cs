using SolidPrincipleProject.SingleResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.InterfaceSubsitituion.Services
{
    public class EBook : Book, IBookDownloadable
    {
        public void Download()
        {
            Console.WriteLine($"Downloading eBook: {Name} by {Author}");
        }
    }
}
