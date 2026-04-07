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

namespace WPFLearningApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 _window1;
        Window2 _window2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void openWindow1(object sender, RoutedEventArgs e)
        {
            _window1 = new Window1();
            _window1.Show();
        }
        private void openWindow2(object sender, RoutedEventArgs e)
        {
            _window2 = new Window2();
            _window2.Show();
        }

        void openWindow3(object sender, RoutedEventArgs e)
        {

        }
    }
}
