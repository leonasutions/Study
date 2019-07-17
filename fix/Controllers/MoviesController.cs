using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fix.Models;

namespace fix.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }


        public ActionResult Detail(int id)
        {
            var movies = _context.Movies.SingleOrDefault(c => c.Id == id);


            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }
    }
}