using BooksGallery.Models;
using System.Collections.Generic;

namespace BooksGallery.Services
{
    public class Data : IData
    {
        public List<Book> Books { get; set; }

        public Data()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "The Hunger Games",
                    Author = "Suzanne Collins",
                    Description = "The first installment of the Hunger Games series.",
                    Image = "hungergames.jpg"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Catching Fire",
                    Author = "Suzanne Collins",
                    Description = "The second installment of the Hunger Games series.",
                    Image = "catchingfire.jpg"
                },
                new Book()
                {
                    Id = 3,
                    Title = "MockingJay",
                    Author = "Suzanne Collins",
                    Description = "The third installment of the Hunger Games series.",
                    Image = "mockingjay.jpg"
                },
                new Book()
                {
                    Id = 4,
                    Title = "Harry Potter and the Sorcerer's Stone",
                    Author = "J. K. Rowling",
                    Description = "The first installment of the Harry Potter series.",
                    Image = "sorcerersstone.jpg"
                },
                new Book()
                {
                    Id = 5,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Author = "J. K. Rowling",
                    Description = "The second installment of the Harry Potter series.",
                    Image = "chamberofsecrets.jpg"
                },
                new Book()
                {
                    Id = 6,
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    Author = "J. K. Rowling",
                    Description = "The third installment of the Harry Potter series.",
                    Image = "prisonerofazkaban.jpg"
                },
                new Book()
                {
                    Id = 7,
                    Title = "Harry Potter and the Goblet of Fire",
                    Author = "J. K. Rowling",
                    Description = "The fourth installment of the Harry Potter series.",
                    Image = "gobletoffire.jpg"
                },
                new Book()
                {
                    Id = 8,
                    Title = "Harry Potter and the Order of the Phoenix",
                    Author = "J. K. Rowling",
                    Description = "The fifth installment of the Harry Potter series.",
                    Image = "orderofthephoenix.jpg"
                },
                new Book()
                {
                    Id = 9,
                    Title = "Harry Potter and the Half-Blood Prince",
                    Author = "J. K. Rowling",
                    Description = "The sixth installment of the Harry Potter series.",
                    Image = "halfbbloodprince.jpg"
                },
                new Book()
                {
                    Id = 10,
                    Title = "Harry Potter and the Deathly Hallows",
                    Author = "J. K. Rowling",
                    Description = "The last installment of the Harry Potter series.",
                    Image = "deathlyhallows.jpg"
                }
            };
        }

        public List<Book> ReadAll()
        {
            return Books;
        }
        public Book GetBook(int? id)
        {
            if(id == null)
            {
                return null;
            }
            else
            {
                return Books.Find(x => x.Id == id);
            }
        }
        public void AddBook(Book book)
        {
            throw new System.NotImplementedException();
        }
        public void UpdateBook(Book book)
        {
            throw new System.NotImplementedException();
        }
        public void DeleteBook(int? id)
        {
            throw new System.NotImplementedException();
        }
    }
}
