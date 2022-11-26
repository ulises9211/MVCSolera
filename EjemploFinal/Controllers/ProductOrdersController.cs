using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EjemploFinal.Models;

namespace EjemploFinal.Controllers
{
    public class ProductOrdersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ProductOrders
        public ActionResult Index()
        {
            var productOrders = db.ProductOrders.Include(p => p.order).Include(p => p.product);
            return View(productOrders.ToList());
        }

        // GET: ProductOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductOrder productOrder = db.ProductOrders.Find(id);
            if (productOrder == null)
            {
                return HttpNotFound();
            }
            return View(productOrder);
        }

        // GET: ProductOrders/Create
        public ActionResult Create()
        {
            ViewBag.Parametro = Request.QueryString["name"];
            ViewBag.Id = Request.QueryString["id"];

            ViewBag.orderId = new SelectList(db.Orders, "id", "id");
            ViewBag.productId = new SelectList(db.Products, "id", "productName");
            return View();
        }

        // POST: ProductOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,orderId,productId")] ProductOrder productOrder)
        {
            if (ModelState.IsValid)
            {
                db.ProductOrders.Add(productOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.orderId = new SelectList(db.Orders, "id", "id", productOrder.orderId);
            ViewBag.productId = new SelectList(db.Products, "id", "productName", productOrder.productId);
            return View(productOrder);
        }

        // GET: ProductOrders/Edit/5
        public ActionResult Add(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductOrder productOrder = db.ProductOrders.Find(id);
            if (productOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.orderId = new SelectList(db.Orders, "id", "id", productOrder.orderId);
            ViewBag.productId = new SelectList(db.Products, "id", "productName", productOrder.productId);
            return View(productOrder);
        }

        // POST: ProductOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,orderId,productId")] ProductOrder productOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.orderId = new SelectList(db.Orders, "id", "id", productOrder.orderId);
            ViewBag.productId = new SelectList(db.Products, "id", "productName", productOrder.productId);
            return View(productOrder);
        }

        // GET: ProductOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductOrder productOrder = db.ProductOrders.Find(id);
            if (productOrder == null)
            {
                return HttpNotFound();
            }
            return View(productOrder);
        }

        // POST: ProductOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductOrder productOrder = db.ProductOrders.Find(id);
            db.ProductOrders.Remove(productOrder);
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
