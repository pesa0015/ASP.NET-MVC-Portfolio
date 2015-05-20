using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private SitesDBContext db = new SitesDBContext();

        // GET: /Sites/
        public ActionResult Index()
        {
            return View(db.Sites.ToList());
        }
    }
}
