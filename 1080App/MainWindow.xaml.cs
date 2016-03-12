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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _1080App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void moveUp(Image img)
        {
            var top = Canvas.GetTop(img);
            TranslateTransform newImg = new TranslateTransform();
            img.RenderTransform = newImg;
            DoubleAnimation anim = new DoubleAnimation(0, top + 10, TimeSpan.FromSeconds(1));
            newImg.BeginAnimation(TranslateTransform.YProperty, anim);
        }
    }
}
