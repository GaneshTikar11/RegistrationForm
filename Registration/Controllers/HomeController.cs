using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        RegMVCEntities db = new RegMVCEntities();
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(tblRegistration obj)

        {
            if (ModelState.IsValid)
            {
                
                db.tblRegistrations.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }

        public ActionResult ddlList()
        {
            var items = db.tbldistricts.ToList();
            if (items != null)
            {
                ViewBag.data = items;
            }

            return View();
        }

    }
}