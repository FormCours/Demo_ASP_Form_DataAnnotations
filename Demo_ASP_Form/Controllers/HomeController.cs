using Demo_ASP_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_ASP_Form.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Person()) ;
        }
        [HttpPost]
        public ActionResult Index(Person p)
        {
            if (string.IsNullOrWhiteSpace(p.Firstname) || string.IsNullOrWhiteSpace(p.Lastname))
            {
                if (string.IsNullOrWhiteSpace(p.Firstname))
                {
                    ModelState.AddModelError("Firstname", "Vous donnez un prénom");
                }
                if (string.IsNullOrWhiteSpace(p.Lastname))
                {
                    ModelState.AddModelError("Lastname", "Vous donnez un nom >_<");
                }


                return View(p);
            }

            return RedirectToAction(nameof(Confirme), p);
        }


        public ActionResult Confirme(Person p)
        {

            return View(p);
        }
    }
}