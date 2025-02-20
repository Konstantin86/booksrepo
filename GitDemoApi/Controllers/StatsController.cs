using Microsoft.AspNetCore.Mvc;
using System.Linq;
using GitDemoApi.Data;

namespace GitDemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatsController : ControllerBase
    {
        // GET /stats/books
        [HttpGet("books")]
        public IActionResult GetBooksStats()
        {
            var totalBooks = BookRepository.Books.Count;
            var averageYear = BookRepository.Books.Average(b => b.Year);
            var booksPerAuthor = BookRepository.Books
                .GroupBy(b => b.Author)
                .Select(g => new { Author = g.Key, Count = g.Count() })
                .ToList();

            return Ok(new { totalBooks, averageYear, booksPerAuthor });
        }
    }
}
