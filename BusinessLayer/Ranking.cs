using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Ranking
    {
        public int ID { get; set; }
        public Viewer Viewers { get; set; }
        public List<Movie> Movies { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
