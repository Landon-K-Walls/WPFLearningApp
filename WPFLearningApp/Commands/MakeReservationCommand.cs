using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLearningApp.Models.Window2;
using WPFLearningApp.ViewModels;

namespace WPFLearningApp.Commands
{
    class MakeReservationCommand : CommandBase
    {
        private readonly Hotel _hotel;
        private readonly MakeReservationViewModel _mrvm;
        public MakeReservationCommand(MakeReservationViewModel mrvm, Hotel hotel)
        {
            _hotel = hotel;
            _mrvm = mrvm;
        }

        public override void Execute(object parameter)
        {
            if (_hotel != null && _mrvm != null)
                _hotel.MakeReservation(_mrvm.PullReservationData());
            else throw new NullReferenceException("Hotel OR MakeReservationViewModel");
        }
    }
}
