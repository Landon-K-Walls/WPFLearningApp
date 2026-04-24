using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLearningApp.Models.Window2;

namespace WPFLearningApp.DBContext
{
    class LearningAppDBContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }
    }
}
