using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            MovieContext movieContext = new MovieContext();
            List<Movie> movie = movieContext.Movies.ToList();
            return View(movie);
        }
       public ActionResult Details(int id)
        {
            MovieContext movieContext = new MovieContext();
            Movie movie = movieContext.Movies.Single(mov => mov.MovieID == id);
            return View(movie);
        }
    }
}