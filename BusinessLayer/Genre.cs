using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public List<Movie> Movies { get; set; }

        public Genre() { }

        public Genre(string name)
        {
            Name = name;
            //Movies = new List<Movie>();
        }
    }
}
