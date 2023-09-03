using SolidPrincipleProject.SingleResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.InterfaceSubsitituion.Services
{
    public class Audiobook : Book, IBookListenable,IBookDownloadable
    {
        public void Download()
        {
            Console.WriteLine($"Downloading audiobook: {Name} by {Author}");
        }

        public void Listen()
        {
            Console.WriteLine($"Listening to Audiobook: {Name} by {Author}");
        }
    }
}
