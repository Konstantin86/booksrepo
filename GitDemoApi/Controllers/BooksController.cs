using Microsoft.AspNetCore.Mvc;
using System.Linq;
using GitDemoApi.Models;
using GitDemoApi.Data;

namespace GitDemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        // GET /books
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(BookRepository.Books);
        }

        // GET /books/{id}
        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = BookRepository.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }

        // POST /books
        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            newBook.Id = BookRepository.Books.Any() ? BookRepository.Books.Max(b => b.Id) + 1 : 1;
            BookRepository.Books.Add(newBook);
            return CreatedAtAction(nameof(GetBook), new { id = newBook.Id }, newBook);
        }

        // PUT /books/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = BookRepository.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Year = updatedBook.Year;
            return NoContent();
        }

        // DELETE /books/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = BookRepository.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            BookRepository.Books.Remove(book);
            return NoContent();
        }
    }
}