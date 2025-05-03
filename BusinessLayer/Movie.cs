using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class Movie
    {
        [Key]
        public string MovieAdress { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
        [Required]
        public decimal Review { get; set; }

        private Movie() { }

        public Movie(string title, string director, Genre genre, int releaseYear, decimal review)
        {
            Title = title;
            Director = director;
            Genre = genre;
            ReleaseYear = releaseYear;
            Review = review;
        }
    }
}
