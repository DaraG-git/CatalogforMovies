using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Ranking
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public Viewer Viewers { get; set; }
        [Required]
        public List<Movie> Movies { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
    }
}
