using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Lab2.Task2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer timer;
        private readonly string figuresString = "M1 157C8.18884 69.3442 32.1596 32.4999 132 2C197.434 -1.92191 225.316 11.8068 273 40C306.8 83.5753 317.456 108.932 311 157C336.823 90.374 381.141 76.6902 395 75C408.859 73.3098 521.247 104.745 532 157C324.632 157 208.368 157 1 157Z";
     
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += timer_randomAnimationTime;
            timer.Start();
        }

        private void timer_randomAnimationTime(object sender, EventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(new Random().Next(5, 15));

            PlayAnim();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Попали");
        }

        private void PlayAnim()
        {
            var pathGeometry = new PathGeometry
            {
                Figures = PathFigureCollection.Parse(figuresString)
            };

            var animation1 = new DoubleAnimationUsingPath
            {
                Source = PathAnimationSource.X,
                Duration = new Duration(TimeSpan.FromSeconds(4)),
                AccelerationRatio = 0.5,
                PathGeometry = pathGeometry
            };

            var animation2 = new DoubleAnimationUsingPath
            {
                Source = PathAnimationSource.Y,
                Duration = new Duration(TimeSpan.FromSeconds(4)),
                AccelerationRatio = 0.5,
                PathGeometry = pathGeometry
            };

            MyAnimatedTranslateTransform.BeginAnimation(TranslateTransform.XProperty, animation1);
            MyAnimatedTranslateTransform.BeginAnimation(TranslateTransform.YProperty, animation2);
        }
    }
}
