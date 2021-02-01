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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Beenden_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msr = MessageBox.Show("Wollen Sie wirklich Beenden?", "Beenden", MessageBoxButton.YesNo);

            if (msr == MessageBoxResult.Yes)
            {
                this.Close();
            }

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
