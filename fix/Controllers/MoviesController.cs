
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using fix.Migrations;
using fix.Models;
using fix.ViewModel;


namespace fix.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
       
        // GET: Movies.
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MoviesFormViewModel

            {
                Movie = movie,
                Genres = _context.Genre.ToList()
            };
            return View("MoviesForm", viewModel);
        }
        public ActionResult New()
        {
            var genre = _context.Genre.ToList();
            var viewModel = new MoviesFormViewModel
                {
                    Genres = genre
                }
                ;


            return View("MoviesForm", viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movie movie
        )
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var customerInDb = _context.Movies.Single(c => c.Id == movie.Id);
                customerInDb.Name = movie.Name;
                customerInDb.GenreId = movie.GenreId;
                customerInDb.NumberInStock = movie.NumberInStock;
                customerInDb.ReleaseDate = movie.ReleaseDate;
            }
            _context.SaveChanges();



            return RedirectToAction("Index", "Movies");
        }

    }
}