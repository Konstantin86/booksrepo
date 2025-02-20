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
            new Book { Id = 3, Title = "Brave New World", Author = "Aldous Huxley", Year = 1932 },
            new Book { Id = 4, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 },
            new Book { Id = 5, Title = "Moby Dick", Author = "Herman Melville", Year = 1851 },
            new Book { Id = 6, Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813 },
            new Book { Id = 7, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951 },
            new Book { Id = 8, Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1937 },
            new Book { Id = 9, Title = "Fahrenheit 451", Author = "Ray Bradbury", Year = 1953 },
            new Book { Id = 10, Title = "Animal Farm", Author = "George Orwell", Year = 1945 }
        };
    }
}