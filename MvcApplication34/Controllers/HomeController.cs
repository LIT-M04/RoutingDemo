using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication34.Controllers
{
    public class HomeController : Controller
    {
        [Route("/home/foobar")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/test/{stuff}/hello/{morestuff}")]
        public ActionResult Test(string stuff, string moreStuff, int x)
        {
            ViewBag.Stuff = stuff;
            ViewBag.MoreStuff = moreStuff;
            ViewBag.Avsholom = x;
            return View();
        }

        [Route("/category/{categoryName}")]
        public ActionResult Categories(string categoryName)
        {
            ViewBag.CategoryName = categoryName;
            return View();
        }

        [Route("/product/{id:int}")]
        public ActionResult ProductsPage(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        //[Route("/product/{name}")]
        //public ActionResult ProductsPage(string name)
        //{
        //    ViewBag.Id = name;
        //    return View();
        //}

    }
}
