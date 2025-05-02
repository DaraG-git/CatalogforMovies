using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace BusinessLayer
{
    public abstract class Movie
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
        public decimal Review { get; set; }
    }
}
