using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class HallController : Controller
            {
                // GET: Hall
               public ActionResult Index()
                {
                    HallContext hallContext = new HallContext();
                    List<Hall> hall = hallContext.Hall.ToList();
                    return View(hall);
                }
           public ActionResult Details(int id)
            {
                MovieHallContext moviehallContext = new MovieHallContext();
                List<MovieHall> moviehall = moviehallContext.MovieHall.Where(mov => mov.HallID == id).ToList();
                return View(moviehall);
            }
    }
}
