using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFLearningApp.Commands;
using WPFLearningApp.Models.Window2;
using WPFLearningApp.Stores;
using WPFLearningApp.Services;

namespace WPFLearningApp.ViewModels
{
    class ReservationListingViewModel : ViewModelBase
    {
        private readonly Hotel _hotel;
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(Hotel hotel, NavigationStore navigationStore, Func<MakeReservationViewModel> makeReservationViewModel)
        {
            _hotel = hotel;
            _reservations = new ObservableCollection<ReservationViewModel>();

            foreach(Reservation res in _hotel.GetAllReservations())
            {
                _reservations.Add(new ReservationViewModel(res));
            }

            MakeReservationCommand = new NavigateCommand(new NavigationService(navigationStore, makeReservationViewModel));
        }
    }
}
