using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrack.Models;

namespace TimeTrack.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public string Description { get; set; }
    }
}
