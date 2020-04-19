using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public string Description { get; set; }

        public DateTime Start { get; set; }
        public DateTime? End { get; set; }

        public int WorkId { get; set; }
        public Work Work { get; set; }

    }
}
