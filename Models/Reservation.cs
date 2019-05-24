using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Movie { get; set; }
        public int HallID { get; set; }
        public int SeatID { get; set; }
        public int ReservationID { get; set; }

    }
}