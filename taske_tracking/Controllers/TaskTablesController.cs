using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using taske_tracking.Models;

namespace taske_tracking.Controllers
{
    [Authorize (Roles ="Admins")    ]
    public class TaskTablesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [AllowAnonymous]
        // GET: TaskTables
        public ActionResult Index()
        {
            return View(db.TaskTables.ToList());
        }
        [AllowAnonymous]
        // GET: TaskTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskTable taskTable = db.TaskTables.Find(id);
            if (taskTable == null)
            {
                return HttpNotFound();
            }
            return View(taskTable);
        }

        // GET: TaskTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,title,details,assingname,date")] TaskTable taskTable)
        {
            if (ModelState.IsValid)
            {
                db.TaskTables.Add(taskTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskTable);
        }

        // GET: TaskTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskTable taskTable = db.TaskTables.Find(id);
            if (taskTable == null)
            {
                return HttpNotFound();
            }
            return View(taskTable);
        }

        // POST: TaskTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,title,details,assingname,date")] TaskTable taskTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskTable);
        }

        // GET: TaskTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskTable taskTable = db.TaskTables.Find(id);
            if (taskTable == null)
            {
                return HttpNotFound();
            }
            return View(taskTable);
        }

        // POST: TaskTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskTable taskTable = db.TaskTables.Find(id);
            db.TaskTables.Remove(taskTable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
