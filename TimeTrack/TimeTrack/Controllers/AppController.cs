using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeTrack.Models;

namespace TimeTrack.Controllers
{
    public class AppController : Controller
    {
        TaskContext db;
        public AppController(TaskContext context)
        {
            db = context;
        }
        // GET: App/Timer
        public IActionResult Timer()
        {            
            return View(db.Tasks.ToList());
        }

        // GET: App/Projects
        public IActionResult Projects()
        {
            return View();
        }

        // GET: AppController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(string description)
        {
            var q = description;
            return View();
        }

        // POST: AppController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string description)
        {
            try
            {                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
