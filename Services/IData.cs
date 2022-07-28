using System.Collections.Generic;
using BooksGallery.Models;

namespace BooksGallery.Services
{
    public interface IData
    {
        List<Book> Books { get; set; }
        List<Book> ReadAll();
        Book GetBook(int? id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int? id);
    }
}
