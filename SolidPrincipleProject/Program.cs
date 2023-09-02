using SolidPrincipleProject.SingleResponsiblityPrenciple.Services;

var bookService = new BookService();
bookService.Add(new SolidPrincipleProject.SingleResponsiblityPrenciple.Models.Book()
{
    Id = Guid.NewGuid(),
    CreatedDate = DateTime.Now,
    Author = "Author Author",
    Genre = "Test",
    Language = "en",
    Name = "Test Name",
    PageCount = 10
});
bookService.Add(new SolidPrincipleProject.SingleResponsiblityPrenciple.Models.Book()
{
    Id = Guid.NewGuid(),
    CreatedDate = DateTime.Now,
    Author = "Author Author2",
    Genre = "Test",
    Language = "tr",
    Name = "Book Book",
    PageCount = 20
});
foreach (var book in bookService.GetAll())
{
    Console.WriteLine($"Registered: {book.CreatedDate}");
    Console.WriteLine($"Record Id: {book.Id}");
    Console.WriteLine($"Name:  {book.Name}");
    Console.WriteLine("---------------------------------");
}