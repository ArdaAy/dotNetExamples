using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        
        [OutputCache(Duration = 50, NoStore = true)]
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }

        public ActionResult Customers()
        {
            return View();
        }
    }
}