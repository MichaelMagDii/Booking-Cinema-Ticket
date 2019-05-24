using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class TimeShow
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string Duration { get; set; }
        public int HallID { get; set; }
        public string StartTime { get; set; }

    }
}