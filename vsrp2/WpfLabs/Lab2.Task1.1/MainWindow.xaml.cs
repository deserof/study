using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Lab2.Task1._1
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

        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            var animation1 = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                RepeatBehavior = RepeatBehavior.Forever,
                To = 220,
                AutoReverse = true
            };

            var animation2 = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                RepeatBehavior = RepeatBehavior.Forever,
                To = 80,
                AutoReverse = true
            };

            btn.BeginAnimation(WidthProperty, animation1);
            btn.BeginAnimation(HeightProperty, animation2);
        }

        private void btn_MouseLeave(object sender, MouseEventArgs e)
        {
            var animation1 = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                To = 100
            };

            var animation2 = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                To = 30
            };

            btn.BeginAnimation(WidthProperty, animation1);
            btn.BeginAnimation(HeightProperty, animation2);
        }
    }
}
