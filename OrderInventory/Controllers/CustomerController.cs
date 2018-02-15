using OrderInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderInventory.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = new Customer() { Name = "Keerthi" };
            //return View(customer);
            return Content("Hello World!!");
            //return HttpNotFound();  
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, value = 2 });
        }

        public ActionResult Edit(int movieId)
        {
            return Content("Id=" + movieId) ;
        }

        public ActionResult PageBy(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrEmpty(sortBy))
                sortBy = "Name";

            return Content(string.Format("PageIndex={0} and Sorty By = {1}", pageIndex, sortBy));
        }
    }
}