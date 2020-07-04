using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TimeTrack.Models
{
    public class TaskContext : DbContext
    {
        //Each DBSet property would relate to a separate table in the DB
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public void AddTask(string description)
        {
            Tasks.AddRange(new Task
            {
                ProjectId = 1,
                Description = description
            });
        }
    }
}
