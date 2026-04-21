using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFLearningApp.Commands;
using WPFLearningApp.Models.Window2;
using WPFLearningApp.Services;
using WPFLearningApp.Stores;

namespace WPFLearningApp.ViewModels
{
    class MakeReservationViewModel : ViewModelBase
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        
        private int _roomNumber;
        /// <summary>
        /// Gets or sets the number of the room to be reserved within the view model.
        /// </summary>
        public int RoomNumber
        {
            get { return _roomNumber; }
            set
            {
                _roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            }
        }

        private int _floorNumber;
        public int FloorNumber
        {
            get { return _floorNumber; }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        private DateTime _startDate = DateTime.Today;
        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate = DateTime.Today;
        public DateTime EndDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        public bool ReservationIsValid =>
            !string.IsNullOrWhiteSpace(_username)
            && _floorNumber >= 0
            && _roomNumber >= 0
            && _startDate.Date >= DateTime.Today.Date
            && _endDate.Date >= _startDate.Date;

        /// <summary>
        /// Creates and returns a new <c>Reservation</c> instance from the view model
        /// </summary>
        /// <returns></returns>
        public Reservation PullReservationData() =>
            new Reservation(
                new RoomID(
                    _floorNumber,
                    _roomNumber),
                _username,
                _startDate,
                _endDate);

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel(Hotel hotel, NavigationStore navigationStore, Func<ReservationListingViewModel> makeReservationViewModel)
        {
            SubmitCommand = new MakeReservationCommand(this, hotel, new NavigationService(navigationStore, makeReservationViewModel));
            CancelCommand = new NavigateCommand(new NavigationService(navigationStore, makeReservationViewModel));
        }
    }
}
