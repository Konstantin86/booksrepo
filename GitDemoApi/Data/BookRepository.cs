using System.Collections.Generic;
using GitDemoApi.Models;

namespace GitDemoApi.Data
{
    public static class BookRepository
    {
        public static List<Book> Books { get; set; } = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
            new Book { Id = 2, Title = "THE HOBBIT", Author = "J. R. R. Tolkien", Year = 1937 }
        };
    }
}