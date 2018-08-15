using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith", Id = 1},
                new Customer { Name = "Mary Williams", Id = 2}
            };

            var viewModel = new RandomMovieViewModel 
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

    }

}