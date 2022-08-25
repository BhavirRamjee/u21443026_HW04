using u21443026_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21443026_HW04.Controllers
{
    public class HomeController : Controller
    {
        // Repository 
       
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Home()
        {
           
            return View(List.Programs());
        }

        public ActionResult Private()
        {
            
            return View();
        }
        public ActionResult State()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Private(string classId, int grade, int hours, string stateOffer, string mentors, int levelEd)
        {
            Random random = new Random();
            int id = random.Next(1, 1000);
            State factory = new State(id, classId, grade, hours, stateOffer, mentors, levelEd);
            List.Add(factory);
            
            return View();
        }

        [HttpPost]
        public ActionResult State(string classId, int grade, int hours, double months, string schoolType)
        {
            int id = 0;
            Private state = new Private(id, classId, grade, hours, schoolType, months);
            List.Add(state);
            id++;
            return View();
        }

        public ActionResult Delete(int id)
        {
            List.Delete(id);
           return RedirectToAction("Home");
        }

        [HttpPost]
      

        public ActionResult ViewEnergy()
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Home");
        }
    }
}