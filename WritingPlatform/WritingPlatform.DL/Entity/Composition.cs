using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingPlatform.DL.Entity
{
    public class Composition
    {
        public int Id { get; set; }
        public Genre Genre { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Rating { get; set; }
    }
}
