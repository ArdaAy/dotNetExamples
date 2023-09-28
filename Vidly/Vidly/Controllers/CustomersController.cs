using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    
    public class CustomersController : Controller
    {
        List<Customer> cList = new List<Customer>
        {
            new Customer() {Id = 0, Name = "Customer 1"},
            new Customer() {Id = 1, Name = "Customer 2"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(cList);
        }
        
        // Customers/Details
        public ActionResult Details(int id)
        {
            return View(cList[id]);
        }
    }
}