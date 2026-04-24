using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLearningApp.DTO
{
    class ReservationDTO
    {
        [Key] public Guid ID;
        public int FloorNumber;
        public int RoomNumber;
        public string Username;
        public DateTime StartTime;
        public DateTime EndTime;
    }
}
