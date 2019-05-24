using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Cinema.Models;

namespace Cinema.Models
{
    [Table("Movie")]
    public class Movie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Duration { get; set; }
        public double IBMD { get; set; }

    }
}