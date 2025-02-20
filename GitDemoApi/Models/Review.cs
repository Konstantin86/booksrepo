namespace GitDemoApi.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Reviewer { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }  // e.g., rating out of 5
    }
}
