using SolidPrincipleProject.SingleResponsiblityPrenciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleProject.SingleResponsiblityPrenciple.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book?> _books;
        public BookService()
        {
            _books = new List<Book?>();
        }
        public void Add(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            _books.Add(book);
        }

        public void Delete(Guid id)
        {
            var deleteBook = _books.FirstOrDefault(x => x != null && x.Id == id);
            if (deleteBook != null)
            {
                _books.Remove(deleteBook);
            }
        }

        public Book? Get(Guid id)
        {
            return _books.FirstOrDefault(x => x != null && x.Id == id);
        }

        public List<Book?> GetAll()
        {
            return _books;
        }

        public void Update(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            var existingBook = _books.FirstOrDefault(x => x != null && x.Id == book.Id);
            if (existingBook != null)
            {
                if (existingBook.Name != book.Name)
                {
                    existingBook.Name = book.Name;
                }

                if (existingBook.Author != book.Author)
                {
                    existingBook.Author = book.Author;
                }

                if (existingBook.Genre != book.Genre)
                {
                    existingBook.Genre = book.Genre;
                }
                if(existingBook.PageCount != book.PageCount)
                {
                    existingBook.PageCount= book.PageCount;
                }

                if (existingBook.Language != book.Language)
                {
                    existingBook.Language = book.Language;
                }

            }
            else
            {
                throw new ArgumentException("Güncellenmek istenen kitap bulunamadı.");
            }

        }
    }
}
