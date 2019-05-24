using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Linq;

namespace Cinema.Models
{
    public class SeatContext : DbContext
    {
        public DbSet<Seat> Seats { get; set; }
    }
}