namespace SolidPrincipleProject.SingleResponsibility.Models;

public class Book : Base
{
    public string? Name { get; set; }
    public string? Author { get; set; }
    public string? Genre { get; set; }
    public int? PageCount { get; set; }
    public string? Language { get; set; }
    public decimal Price { get; set; }
    public bool IsEBook { get; set; }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Name}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Price: {Price:C}");
    }
}