using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = string.Format("{0} :: {1} {2}",
                RouteData.Values["controller"],
                RouteData.Values["action"],
                RouteData.Values["id"]);

            var model = new RestaurantReview()
            {
                Name = "Tersiguel",
                Rating = 9
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            ViewBag.Message = string.Format("{0} :: {1} {2}",
                RouteData.Values["controller"],
                RouteData.Values["action"],
                RouteData.Values["id"]);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cuisine()
        {
            ViewBag.Message = "Your cuisine page.";

            return View();
        }
    }
}