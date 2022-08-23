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
using System.Windows.Threading;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer dispatcherTimer=new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            //dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            //dispatcherTimer.Tick += DispatcherTimer_Tick;
            // img1.Source = new ImageBrush(new Image("img.gif"));
            //var image = new BitmapImage();
            //image.BeginInit();
            //image.UriSource = new Uri("https://i.pinimg.com/originals/e3/98/00/e398005be9081126972e577938dad26a.gif");
            //image.EndInit();
            //img1.Source = image;



            // MessageBox.Show(img1.Source.ToString()); 


            //listbox.ItemsSource = GetCars();

            
        }


        public List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Model="M5",
                    Vendor="BMW",
                    Year=2022
                },
                new Car
                {
                    Model="AMG63",
                    Vendor="Mercedes",
                    Year=2020
                },
                new Car
                {
                    Model="Cruze",
                    Vendor="Chevrolet",
                    Year=2018
                },
                new Car
                {
                    Model="Sonata",
                    Vendor="Hyundai",
                    Year=2010
                }
            };
        }

        private void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            //if (prgbar.Value < prgbar.Maximum)
            //{
            //    prgbar.Value += 5;
            //}
            //else
            //{
            //    dispatcherTimer.Stop();
            //    MessageBox.Show("Downloading completed");
            //}
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //   // dispatcherTimer.Start();
        //}

        private void myslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //resultLbl.Content=Convert.ToInt32(myslider.Value).ToString();
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var car=listbox.SelectedItem as Car;
            //this.Title = car.Model;
            //MessageBox.Show(car.ToString());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var result = sender as ComboBox;
            var item = result.SelectedItem as ComboBoxItem;
            var stpPanel=item.Content as StackPanel;
            foreach (var i in stpPanel.Children)
            {
                if (i is TextBlock tb)
                {
                    MessageBox.Show(tb.Text);
                }
            }
        }
    }
}
