using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting;
using AttributeRouting.Web.Mvc;

namespace MvcApplication34.Controllers
{
    [RoutePrefix("/cats")]
    public class CategoryController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
