using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLearningApp.Models.Window2;

namespace WPFLearningApp.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel(Hotel hotel)
        {
            CurrentViewModel = new MakeReservationViewModel(hotel);
        }
    }
}
