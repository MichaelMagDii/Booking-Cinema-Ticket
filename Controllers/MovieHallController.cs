using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace Cinema.Controllers
{
    public class MovieHallController : Controller
    {
        // GET: MovieHome
       public ActionResult index(int id)
        {
            MovieHallContext moviehallContext = new MovieHallContext();
            List<MovieHall> moviehall = moviehallContext.MovieHall.Where(mov => mov.HallID == id).ToList();
            return View(moviehall);
        }
    }
}