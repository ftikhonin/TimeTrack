using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class HomeController : Controller
    {
        WorkContext db;       
        public HomeController(WorkContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Works.ToList());
        }
        [HttpPost]
        public IActionResult Index(string description)
        {
            db.AddWork(description);
            db.SaveChanges();
            return View(db.Works.ToList());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Start(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.WorkId = id;
            return View();
        }

        [HttpPost]
        public string Start(Session session)
        {
            db.Sessions.Add(session);
            // Save to DB
            db.SaveChanges();
            return "Активно с " + session.Start;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
