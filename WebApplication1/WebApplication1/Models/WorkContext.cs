using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class WorkContext : DbContext
    {
        //Each DBSet property would relate to a separate table in the DB
        public DbSet<Work> Works { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public WorkContext(DbContextOptions<WorkContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
