using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Linq;
using System.Data.SqlClient;
using Cinema.Models;

namespace Cinema.Models
{
    public class MovieHallContext :DbContext
    {
        public DbSet<MovieHall> MovieHall { get; set; }
        public DbSet<Hall> Hall { get; set; }

        public DbSet<Reservation> Reservation { get; set; }
    }
}