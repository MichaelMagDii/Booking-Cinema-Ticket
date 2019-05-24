using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Cinema.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Reservation reservation)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ReservationContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Reservation_Procdure", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.Value = reservation.ID;
                cmd.Parameters.Add(ParID);

                SqlParameter ParName = new SqlParameter();
                ParID.ParameterName = "@Name";
                ParID.Value = reservation.Name;
                cmd.Parameters.Add(ParName);

                SqlParameter ParPhone = new SqlParameter();
                ParID.ParameterName = "@Phone";
                ParID.Value = reservation.Phone;
                cmd.Parameters.Add(ParPhone);

                SqlParameter ParEmail = new SqlParameter();
                ParID.ParameterName = "@Email";
                ParID.Value = reservation.Email;
                cmd.Parameters.Add(ParEmail);

                SqlParameter ParMovie = new SqlParameter();
                ParID.ParameterName = "@Movie";
                ParID.Value = reservation.Movie;
                cmd.Parameters.Add(ParID);

                SqlParameter ParHall = new SqlParameter();
                ParID.ParameterName = "@HallID";
                ParID.Value = reservation.HallID;
                cmd.Parameters.Add(ParHall);

                SqlParameter ParSeat = new SqlParameter();
                ParID.ParameterName = "@SeatID";
                ParID.Value = reservation.SeatID;
                cmd.Parameters.Add(ParSeat);
                con.Open();
                cmd.ExecuteNonQuery();
            }
                return View();
        }
    }
}