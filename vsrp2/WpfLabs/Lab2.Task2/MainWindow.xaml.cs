using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Lab2.Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_randomAnimationTime;
            timer.Start();
        }

        void timer_randomAnimationTime(object sender, EventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(new Random().Next(5, 15));

            ExecuteAnimation();
        }

        private void ExecuteAnimation()
        {
            var sb = FindResource("PlayAnimation") as Storyboard;

            if (sb != null) 
            { 
                BeginStoryboard(sb); 
            }
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Попали");
        }
    }
}
