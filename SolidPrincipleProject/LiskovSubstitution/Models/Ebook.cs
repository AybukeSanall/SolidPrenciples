using SolidPrincipleProject.SingleResponsibility.Models;

namespace SolidPrincipleProject.LiskovSubstitution.Models
{
    public class Ebook:Book
    {
        public string? Format { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Format: {Format}");
        }
    }
}
