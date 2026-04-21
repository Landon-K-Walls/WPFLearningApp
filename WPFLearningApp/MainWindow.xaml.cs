using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFLearningApp.Windows;
using WPFLearningApp.ViewModels;
using WPFLearningApp.Models.Window2;
using WPFLearningApp.Stores;

namespace WPFLearningApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 _window1;
        Window2 _window2;

        private readonly Hotel _hotel;

        private readonly NavigationStore _navigationStore;

        public MainWindow()
        {
            InitializeComponent();
            _hotel = new Hotel("Town Bicycle Hotel");
            _navigationStore = new NavigationStore();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            _window1 = new Window1();
            _window1.Show();
        }

        private void openWindow2(object sender, RoutedEventArgs e)
        {
            _navigationStore.CurrentViewModel = new ReservationListingViewModel(_hotel, _navigationStore, CreateMakeReservationViewModel);

            _window2 = new Window2()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            _window2.Show();
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel, _navigationStore, CreateReservationListingViewModel);
        }

        private ReservationListingViewModel CreateReservationListingViewModel()
        {
            return new ReservationListingViewModel(_hotel, _navigationStore, CreateMakeReservationViewModel);
        }

        void openWindow3(object sender, RoutedEventArgs e)
        {

        }
    }
}
