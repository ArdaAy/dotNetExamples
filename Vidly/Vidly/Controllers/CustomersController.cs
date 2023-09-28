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
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        List<Customer> cList = new List<Customer>
        {
            new Customer() {Id = 0, Name = "Customer 1"},
            new Customer() {Id = 1, Name = "Customer 2"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var customer = _context.Customers.ToList();
            return View(customer);
        }
        
        // Customers/Details
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
            //return View(cList[id]);
        }

        
    }
}