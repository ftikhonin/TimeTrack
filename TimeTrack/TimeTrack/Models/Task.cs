using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrack.Models;

namespace TimeTrack.Models
{
    public class Task
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }

        public string Description { get; set; }
    }
}
