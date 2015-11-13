using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public UltimateDb db = new UltimateDb();
        public ActionResult Index()
        {
            ViewBag.Message = "Home Page of Ultimate Organiser";
            db.Clubs.Add(new Club { ClubName = "Lakers", ClubEmail = "info@lakers.com", ClubDescription = "Basketball Giants" });
            db.SaveChanges();
            var allClubs = db.Clubs.ToList();
            return View(allClubs);
        }

        public ActionResult Details(int? id)
        {
            var selClub = db.Clubs.Find(id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.Message = "Details Page of Club " + selClub.ClubName;
            return View(selClub);
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is the Fourm page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is the Calander page";

            return View();
        }
    }
}