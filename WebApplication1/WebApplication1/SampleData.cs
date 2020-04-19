using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public static class SampleData
    {
        public static void Initialize(WorkContext context)
        {
            if (!context.Works.Any())
            {
                context.Works.AddRange(
                    new Work
                    {
                        Url = "https://redmine.permenergosbyt.ru/issues/101180",
                        Description = "Добавить флаг"
                    },
                    new Work
                    {
                        Url = "https://redmine.permenergosbyt.ru/issues/104796",
                        Description = "Проверить корректность"
                    }
                    ); 
                
                context.SaveChanges();
            }

        }
    }
}
