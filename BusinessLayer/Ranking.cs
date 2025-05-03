using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class Ranking
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public Viewer Viewers { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }  
        [Required]
        public List<Movie> Movies { get; set; }

        private Ranking() { }
        public Ranking(Viewer viewer, DateTime creationDate)
        {
            Viewers = viewer;
            CreationDate = creationDate;
            Movies = new List<Movie>();
        }
    }
}
