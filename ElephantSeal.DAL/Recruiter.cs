using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElephantSearl.DAL.Entities
{
    public class Recruiter
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Organization Company { get; set; }
        public int Rating { get; set; }
    }
}
