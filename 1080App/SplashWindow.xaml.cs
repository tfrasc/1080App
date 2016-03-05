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

namespace _1080App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SplashWindow : Window
    {
        public SplashWindow()
        {
            InitializeComponent();
        }

        private void StartRect_MouseEnter(object sender, MouseEventArgs e)
        {
            StartRect.Opacity = 0;
        }

        private void StartRect_MouseLeave(object sender, MouseEventArgs e)
        {
            StartRect.Opacity = 0.5;
        }

        private void StartRect_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ///destroy current window
            StartRect.Opacity = 1;
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
            this.Close();
        }
    }
}
