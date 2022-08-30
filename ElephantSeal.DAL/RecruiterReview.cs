using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElephantSearl.DAL.Entities
{
    public class RecruiterReview
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
    }
}
