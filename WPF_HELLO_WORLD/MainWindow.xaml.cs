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

namespace WPF_HELLO_WORLD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void BTN_HELLO_Click(object sender, RoutedEventArgs e) =>
            //Serve Hello World MsgBox
            _ = MessageBox.Show("Hello World!", "Hello", MessageBoxButton.OK, MessageBoxImage.Information);
        void timer_Tick(object sender, EventArgs e)
        {
            LAB_DTIME_TICKER.Content = DateTime.Now.ToLongDateString() + ' ' + DateTime.Now.ToLongTimeString();
        }

    }
}
