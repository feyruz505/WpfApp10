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

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            timeLabel.Content = currentTime.ToString("HH:mm:ss");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = string.Empty;
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }



        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length < 4)
            {
                Button button = sender as Button;
                passwordBox.Password += button.Content.ToString();
            }
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            string password = passwordBox.Password;
            if (password == "2004")
            {
                Window newWindow = new Window();
                newWindow.Show();
            }
            else
            {
                MessageBox.Show("Parol Yalnsidir");
            }


        }
    }
}
