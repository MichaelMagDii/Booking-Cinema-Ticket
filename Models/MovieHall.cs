using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using Cinema.Models;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
    [Table("MoviesHall")]
    public class MovieHall
    {  
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string Duration { get; set; }
        public string StartTime { get; set; }
        [Key]
        public int HallID { get; set; }
    }
}