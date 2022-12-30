using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Lab2.Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _milliseconds = 2000;
        private int _hp = 5;
        private int winCount = 0;

        private Dictionary<int, Button> _buttons => new Dictionary<int, Button>
        {
            { 0, WinButton },
            { 1, LoseFirstButton },
            { 2, LoseSecondButton },
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = false;

            WinButton.Content = string.Empty;
            LoseFirstButton.Content = string.Empty;
            LoseSecondButton.Content = string.Empty;

            var storyboard = new Storyboard();
            var shButtons = Shuffle();

            storyboard.Completed += Storyboard_Completed;

            storyboard.Children = new TimelineCollection
            {
                MoveBtn(shButtons.ElementAt(0).Value, WinButton.Margin, TimeSpan.FromMilliseconds(_milliseconds)),
                MoveBtn(shButtons.ElementAt(1).Value, LoseFirstButton.Margin, TimeSpan.FromMilliseconds(_milliseconds)),
                MoveBtn(shButtons.ElementAt(2).Value, LoseSecondButton.Margin, TimeSpan.FromMilliseconds(_milliseconds)),
            };

            storyboard.Begin();
        }

        private ThicknessAnimation MoveBtn(Button button, Thickness thickness, TimeSpan duration)
        {
            ThicknessAnimation thicknessAnimation = new()
            {
                From = button.Margin,
                To = thickness,
                Duration = duration
            };

            Storyboard.SetTarget(thicknessAnimation, button);
            Storyboard.SetTargetProperty(thicknessAnimation, new PropertyPath(MarginProperty));

            return thicknessAnimation;
        }

        private void WinButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = true;

            winCount++;
            _milliseconds -= 500;
            WinButton.Content = "Win";
            LoseFirstButton.Content = "Lose";
            LoseSecondButton.Content = "Lose";
            MessageBox.Show("Угадали");
            if (_milliseconds <= 0) _milliseconds = 500;

            if (winCount == 5)
            {
                MessageBox.Show($"Выиграли. {winCount} раз угадали");
                Environment.Exit(0);
            }
        }

        private void LoseButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = true;

            if (_hp <= 0)
            {
                MessageBox.Show($"Проиграли. {winCount} раз угадали");
                Thread.Sleep(3);
                Environment.Exit(0);
            }

            _hp--;
            MessageBox.Show($"Минус hp. Текущее {_hp}");
        }

        private Dictionary<int, Button> Shuffle()
        {
            Random r = new Random();
            return _buttons.OrderBy(x => r.Next()).ToDictionary(item => item.Key, item => item.Value);
        }

        private void Storyboard_Completed(object? sender, EventArgs e)
        {
            var storyboard = new Storyboard();
            var shButtons = Shuffle();

            storyboard.Children = new TimelineCollection
            {
                MoveBtn(shButtons.ElementAt(0).Value, WinButton.Margin, TimeSpan.FromMilliseconds(_milliseconds)),
                MoveBtn(shButtons.ElementAt(1).Value, LoseFirstButton.Margin, TimeSpan.FromMilliseconds(_milliseconds)),
                MoveBtn(shButtons.ElementAt(2).Value, LoseSecondButton.Margin, TimeSpan.FromMilliseconds(_milliseconds)),
            };

            storyboard.Begin();
        }
    }
}