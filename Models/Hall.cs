using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    [Table("Hall")]
    public class Hall
    {
        public int HallID { get; set; }
        public string Name { get; set; }
        public List<Movie> Movie { get; set; }
    }
}