namespace MovieReviewApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        // One Movie many Genres
        public ICollection<Review> Reviews { get; set; }

    }
}
