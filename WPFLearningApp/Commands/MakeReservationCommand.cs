using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFLearningApp.Models.Exceptions;
using WPFLearningApp.Models.Window2;
using WPFLearningApp.ViewModels;
using WPFLearningApp.Services;

namespace WPFLearningApp.Commands
{
    class MakeReservationCommand : CommandBase
    {
        private readonly Hotel _hotel;
        private readonly MakeReservationViewModel _mrvm;
        private readonly NavigationService _reservationListingNavigationService;
        public MakeReservationCommand(MakeReservationViewModel mrvm, Hotel hotel, NavigationService reservationListingNavigationService)
        {
            _hotel = hotel;
            _mrvm = mrvm;

            _reservationListingNavigationService = reservationListingNavigationService;

            _mrvm.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnCanExecutedChanged();
        }

        public override bool CanExecute(object parameter)
        {
            return _mrvm.ReservationIsValid && base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            try
            {
                if (_hotel != null && _mrvm != null)
                    _hotel.MakeReservation(_mrvm.PullReservationData());
                else throw new NullReferenceException("Hotel OR MakeReservationViewModel is null");

                MessageBox.Show("Successfully made reservation!", "Success");

                _reservationListingNavigationService.Navigate();
            }
            catch (ReservationConflictException exc)
            {
                MessageBox.Show(
                    $"Reservations in conflict! " +
                    $"\n{exc.IncomingReservation}" +
                    $"\nOverlaps with:" +
                    $"\n{exc.ExistingReservation}",
                    "Reservation Conflict",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error,
                    MessageBoxResult.OK);
            }

        }
    }
}
