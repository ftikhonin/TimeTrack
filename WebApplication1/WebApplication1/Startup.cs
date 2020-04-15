using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        IWebHostEnvironment _env;
        public delegate Task RequestDelegate(HttpContext context);
        public Startup(IWebHostEnvironment env)
        {
            _env = env;
        }
        public void ConfigureServices(IServiceCollection services)
        { 
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //// åñëè ïðèëîæåíèå â ïðîöåññå ðàçðàáîòêè
        //if (env.IsDevelopment())
        //{
        //    // òî âûâîäèì èíôîðìàöèþ îá îøèáêå, ïðè íàëè÷èè îøèáêè
        //    app.UseDeveloperExceptionPage();
        //}
        // äîáàâëÿåì âîçìîæíîñòè ìàðøðóòèçàöèè
        //app.UseRouting();

        //// óñòàíàâëèâàåì àäðåñà, êîòîðûå áóäóò îáðàáàòûâàòüñÿ
        //app.UseEndpoints(endpoints =>
        //{
        //    // îáðàáîòêà çàïðîñà - ïîëó÷àåì êîíòåêñò çàïðîñà â âèäå îáúåêòà context
        //    endpoints.MapGet("/", async context =>
        //    {
        //        // îòïðàâêà îòâåòà â âèäå ñòðîêè "Hello World!"
        //        await context.Response.WriteAsync(String.Concat("Hello World! ",$"Application Name: {_env.ApplicationName}"));
        //    });
        //});

        //int x = 2;
        //app.Run(async (context) =>
        //{
        //    x = x * 2;
        //    await context.Response.WriteAsync($"Result: {x}");
        //});

        //int x = 5;
        //int y = 8;
        //int z = 0;
        //app.Use(async (context, next) =>
        //{
        //    z = x * y;
        //    await next.Invoke();
        //});

        //app.Use(async (context, next) =>
        //{
        //    z += x + y;
        //    await next.Invoke();
        //});

        //app.Run(async (context) =>
        //{
        //    await context.Response.WriteAsync($"x * y = {z}");
        //}); 
        public void Configure(IApplicationBuilder app)
        {
            app.Map("/home", home =>
            {
                home.Map("/index", Index);
                home.Map("/about", About);
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Page Not Found");
            });
        }

        private static void Index(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Index");
            });
        }
        private static void About(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("About");
            });
        }
    }
}
