using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrack.Models;

namespace TimeTrack
{
    public static class SampleData
    {
        public static void Initialize(TaskContext context)
        {
            if (!context.Tasks.Any())
            {
                context.Tasks.AddRange(
                    new Models.Task
                    {
                        ProjectId = 2,
                        Description = "Добавить флаг"
                    },
                    new Models.Task
                    {
                        ProjectId = 3,
                        Description = "Проверить корректность"
                    }
                    ); 
                
                context.SaveChanges();
            }

        }
    }
}
