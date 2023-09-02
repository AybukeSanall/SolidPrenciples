using SolidPrincipleProject.SingleResponsibility.Models;
using SolidPrincipleProject.SingleResponsibility.Services;

var bookService = new BookService();
bookService.Add(new Book
{
    Id = Guid.NewGuid(),
    CreatedDate = DateTime.Now,
    Author = "Author Author",
    Genre = "Test",
    Language = "en",
    Name = "Test Name",
    PageCount = 10,
    IsEBook = false,
    Price = 50
});

bookService.Add(new Book
{
    Id = Guid.NewGuid(),
    CreatedDate = DateTime.Now,
    Author = "Author Author2",
    Genre = "Test",
    Language = "tr",
    Name = "Book Book",
    PageCount = 20,
    IsEBook = true,
    Price = 100
});

foreach (var book in bookService.GetAll())
{
    Console.WriteLine($"Registered: {book.CreatedDate}");
    Console.WriteLine($"Record Id: {book.Id}");
    Console.WriteLine($"Book Name:  {book.Name}");
    Console.WriteLine("---------------------------------");
}