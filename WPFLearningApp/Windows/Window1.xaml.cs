using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace WPFLearningApp.Windows
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            string[] comboItems = new[]
            {
                "Coke",
                "Pepsi",
                "Mountain Dew",
                "DR. Pepper"
            };

            ExampleComboBox.ItemsSource = comboItems;
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            bool? openFile = ofd.ShowDialog();
            if(openFile == true)
            {
                MessageBox.Show($"{ofd.FileName}");
            }
        }

        private void ExampleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(
                ExampleComboBox.SelectedItem.ToString());
        }
    }
}
