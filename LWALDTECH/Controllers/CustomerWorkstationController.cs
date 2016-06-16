using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LWALDTECH.Models;

namespace LWALDTECH.Controllers
{
    public class CustomerWorkstationController : Controller
    {
        private CustomerEntities db = new CustomerEntities();

        // GET: /CustomerWorkstation/
        public ActionResult Index()
        {
            var customerworkstations = db.CustomerWorkstations.Include(c => c.Customer);
            return View(customerworkstations.ToList());
        }

        // GET: /CustomerWorkstation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerWorkstation customerworkstation = db.CustomerWorkstations.Find(id);
            if (customerworkstation == null)
            {
                return HttpNotFound();
            }
            return View(customerworkstation);
        }

        // GET: /CustomerWorkstation/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CompanyName");
            return View();
        }

        // POST: /CustomerWorkstation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CustomerID,WorkstationName,WorkstationIPAddress,WorkstationOS,WorkstationID")] CustomerWorkstation customerworkstation)
        {
            if (ModelState.IsValid)
            {
                db.CustomerWorkstations.Add(customerworkstation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CompanyName", customerworkstation.CustomerID);
            return View(customerworkstation);
        }

        // GET: /CustomerWorkstation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerWorkstation customerworkstation = db.CustomerWorkstations.Find(id);
            if (customerworkstation == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CompanyName", customerworkstation.CustomerID);
            return View(customerworkstation);
        }

        // POST: /CustomerWorkstation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CustomerID,WorkstationName,WorkstationIPAddress,WorkstationOS,WorkstationID")] CustomerWorkstation customerworkstation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerworkstation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "CompanyName", customerworkstation.CustomerID);
            return View(customerworkstation);
        }

        // GET: /CustomerWorkstation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerWorkstation customerworkstation = db.CustomerWorkstations.Find(id);
            if (customerworkstation == null)
            {
                return HttpNotFound();
            }
            return View(customerworkstation);
        }

        // POST: /CustomerWorkstation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerWorkstation customerworkstation = db.CustomerWorkstations.Find(id);
            db.CustomerWorkstations.Remove(customerworkstation);
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
