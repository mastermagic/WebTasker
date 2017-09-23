using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTasker.Models;
using System.Data.Entity;

namespace WebTasker.Controllers
{
    public class HomeController : Controller
    {
        TaskContext db = new TaskContext();
        public ActionResult Index()
        {
            IEnumerable<Task> taskList = db.TaskList;
            ViewBag.TaskList = taskList;            
            ViewBag.Count = db.TaskList.Count();
            return View();
        }

        [HttpGet]
        public ActionResult EditTask(int id)
        {
            Task task = db.TaskList.Find(id);
            if (task != null)
            {
                ViewBag.TaskId = task.Id;
                return View(task);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditTask(Task task)
        {
            if (task.Status != State.created)
            {
                task.Check = "checked";
            }
            db.Entry(task).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTask(Task task)
        {
            db.TaskList.Add(task);
            db.SaveChanges();
            IEnumerable<Task> taskList = db.TaskList;
            ViewBag.TaskList = taskList;
            return View("Index");
        }
    }
}