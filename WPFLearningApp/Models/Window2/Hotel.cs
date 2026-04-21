using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFLearningApp.Models.Exceptions;

namespace WPFLearningApp.Models.Window2
{
    class Hotel
    {
        readonly ReservationBook _reservationBook;

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }

        public IEnumerable<Reservation> GetAllReservations() =>
             _reservationBook.GetAllReservations();

        public void MakeReservation(Reservation reservation)
        {
                _reservationBook.AddReservation(reservation);
        }
            
    }
}
