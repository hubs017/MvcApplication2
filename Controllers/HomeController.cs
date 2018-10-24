using MvcApplication2.DbHandlers;
using MvcApplication2.Interfaces;
using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "By Hubs";

            return View();
        }

        public ActionResult Countries()
        {
            IDatabase db = new XMLHandler();

            return View(db.GetCountries());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var country = new CountryModel()
                {
                    Name = Convert.ToString(collection["Name"]),
                    Population = Convert.ToString(collection["Population"]),
                    Currency = Convert.ToString(collection["Currency"]),
                    Continent = Convert.ToString(collection["Continent"]),
                    Capital = Convert.ToString(collection["Capital"])
                };

                IDatabase db = new XMLHandler();

                db.Create(country);

                return RedirectToAction("Countries");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Details(string countryName)
        {
            IDatabase db = new XMLHandler();
            return View(db.GetCountryByName(countryName));
        }
    }
}
