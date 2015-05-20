using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class SitesController : Controller
    {
        private SitesDBContext db = new SitesDBContext();

        // GET: /Sites/
        public ActionResult Index()
        {
            return View(db.Sites.ToList());
        }

        // GET: /Sites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sites sites = db.Sites.Find(id);
            if (sites == null)
            {
                return HttpNotFound();
            }
            return View(sites);
        }

        // GET: /Sites/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Sites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,img_src,a_href,a_href_target")] Sites sites, HttpPostedFileBase img_src)
        {
            if (ModelState.IsValid)
            {
                var path = String.Empty;
                if (img_src != null || img_src.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(img_src.FileName);
                    var filePath = Path.Combine(Server.MapPath("~/Content/Images/Sites"), fileName);

                    img_src.SaveAs(filePath);
                        path = String.Format("/Content/Images/Sites/{0}", fileName);
                        sites.img_src = path;
                        db.Sites.Add(sites);
                        db.SaveChanges();
                        return View();
                    

                }
                
            }

            return View();
        }

        // GET: /Sites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sites sites = db.Sites.Find(id);
            if (sites == null)
            {
                return HttpNotFound();
            }
            return View(sites);
        }

        // POST: /Sites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,img_src,a_href,a_href_target")] Sites sites, HttpPostedFileBase img_src)
        {
            if (ModelState.IsValid)
            {
                var path = String.Empty;
                if (img_src != null || img_src.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(img_src.FileName);
                    var filePath = Path.Combine(Server.MapPath("~/Content/Images/Sites"), fileName);

                    img_src.SaveAs(filePath);
                    path = String.Format("/Content/Images/Sites/{0}", fileName);
                    sites.img_src = path;
                    db.Sites.Add(sites);
                    db.Entry(sites).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");


                }

                
            }
            return View(sites);
        }

        // GET: /Sites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sites sites = db.Sites.Find(id);
            if (sites == null)
            {
                return HttpNotFound();
            }
            return View(sites);
        }

        // POST: /Sites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sites sites = db.Sites.Find(id);
            db.Sites.Remove(sites);
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
