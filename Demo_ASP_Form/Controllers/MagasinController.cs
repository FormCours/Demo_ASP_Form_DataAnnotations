using Demo_ASP_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_ASP_Form.Controllers
{
    public class MagasinController : Controller
    {
        private static List<Meuble> meubles = new List<Meuble>()
        {
            new Meuble() {Id=1, Name="OUFÖ", ForGarden=false, Year=2010, Category="Table", Prix=42, Reference="ABC12345"},
            new Meuble() {Id=1, Name="SÖGË", ForGarden=true, Year=2020, Category="Chaise", Prix=12.99, Reference="CHE45214"}
        };

        public ActionResult Index()
        {
            return View(meubles);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View(new Meuble());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Meuble meuble)
        {
            if (!ModelState.IsValid)
            {
                return View(meuble);
            }

            meubles.Add(meuble);

            return RedirectToAction(nameof(Index));
        }
    }
}