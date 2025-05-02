using System.Reflection.Emit;

namespace BusinessLayer
{
    public abstract class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public Genre Genre { get; set; }
        public int ReleaseYear { get; set; }
        public decimal Review { get; set; }
    }
}
