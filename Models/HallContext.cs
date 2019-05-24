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
    public class HallContext : DbContext
    {
        public DbSet<Hall> Hall { get; set; }
    }
}