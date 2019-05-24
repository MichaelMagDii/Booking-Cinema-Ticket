using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    [Table("Movie")]
    public class Seat
    {
        public int SeatID { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
        public int salary { get; set; }
        public char IsSelect { get; set; }

    }
}