using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using WebApplication3.Models;
using System.Data;
using System.Data.Entity;


namespace WebApplication3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var db = new ProductContext();
            return View(db.Products);
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var db = new ProductContext();
            return View(db.Products.Find(id));
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,DisplayName,MSRP,CurrentPrice,CategoryId")] Product product)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }


            return View();
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var db = new ProductContext();
            return View(db.Products.Find(id));
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,DisplayName,MSRP,CurrentPrice,CategoryId")] Product product)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View();
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {

            }
            base.Dispose(disposing);
        }
    }
}
