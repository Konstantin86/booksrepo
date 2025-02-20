using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using GitDemoApi.Models;

namespace GitDemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewsController : ControllerBase
    {
        // Using a static list as an in-memory repository for demonstration.
        private static List<Review> Reviews = new List<Review>
        {
            new Review { Id = 1, BookId = 1, Reviewer = "Alice", Content = "A gripping tale.", Rating = 5 },
            new Review { Id = 2, BookId = 2, Reviewer = "Bob", Content = "A timeless classic.", Rating = 4 }
        };

        // GET /reviews
        [HttpGet]
        public IActionResult GetReviews()
        {
            return Ok(Reviews);
        }

        // GET /reviews/book/{bookId}
        [HttpGet("book/{bookId}")]
        public IActionResult GetReviewsForBook(int bookId)
        {
            var bookReviews = Reviews.Where(r => r.BookId == bookId).ToList();
            return Ok(bookReviews);
        }

        // POST /reviews
        [HttpPost]
        public IActionResult AddReview([FromBody] Review newReview)
        {
            newReview.Id = Reviews.Any() ? Reviews.Max(r => r.Id) + 1 : 1;
            Reviews.Add(newReview);
            return CreatedAtAction(nameof(GetReviews), new { id = newReview.Id }, newReview);
        }

        // PUT /reviews/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateReview(int id, [FromBody] Review updatedReview)
        {
            var review = Reviews.FirstOrDefault(r => r.Id == id);
            if (review == null)
                return NotFound();

            review.BookId = updatedReview.BookId;
            review.Reviewer = updatedReview.Reviewer;
            review.Content = updatedReview.Content;
            review.Rating = updatedReview.Rating;
            return NoContent();
        }

        // DELETE /reviews/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteReview(int id)
        {
            var review = Reviews.FirstOrDefault(r => r.Id == id);
            if (review == null)
                return NotFound();

            Reviews.Remove(review);
            return NoContent();
        }
    }
}
