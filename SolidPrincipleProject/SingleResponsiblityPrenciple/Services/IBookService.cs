using SolidPrincipleProject.SingleResponsiblityPrenciple.Models;

namespace SolidPrincipleProject.SingleResponsiblityPrenciple.Services
{
    public interface IBookService
    {
        List<Book?> GetAll();
        Book? Get(Guid id);
        void Add(Book book);
        void Delete(Guid id);
        void Update(Book book);

    }
}
