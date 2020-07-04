using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TimeTrack.Models;

namespace TimeTrack.Controllers
{
    
    public class HomeController : Controller
    {
        TaskContext db;       
        public HomeController(TaskContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(db.Tasks.ToList());
        }
        [HttpPost]
        public IActionResult Index(string description)
        {
            db.AddTask(description);
            db.SaveChanges();
            return View(db.Tasks.ToList());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Start(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.TaskId = id;
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
