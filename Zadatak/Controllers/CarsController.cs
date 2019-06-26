using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Zadatak.Models;
using Zadatak.ViewModels;

namespace Zadatak.Controllers
{
    public class CarsController : Controller
    {
        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var cars = _context.Cars.Include(c => c.Genre).ToList();

            return View(cars);
        }

        public ViewResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new CarFormViewModel
            {
                Genres = genres
            };

            return View("CarForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            var viewModel = new CarFormViewModel(car)
            {
                Genres = _context.Genres.ToList()
            };

            return View("CarForm", viewModel);
        }


        public ActionResult Details(int id)
        {
            var car = _context.Cars.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            return View(car);

        }


        // GET: Movies/Random
        public ActionResult Random()
        {
            var car = new Car() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomCarViewModel
            {
                Car = car,
                Customers = customers
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Car car)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CarFormViewModel(car)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("CarForm", viewModel);
            }

            if (car.Id == 0)
            {
                
                _context.Cars.Add(car);
            }
            else
            {
                var carInDb = _context.Cars.Single(c => c.Id == car.Id);
                carInDb.Name = car.Name;
               
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Cars");
        }
    }
}