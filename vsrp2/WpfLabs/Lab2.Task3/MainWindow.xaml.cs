using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab2.Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            (Button firstButton, Button secondButton) = GetTwoRandonButtons();

            var firstLeftPos = Canvas.GetLeft(firstButton);

            var secondLeftPos = Canvas.GetLeft(secondButton);

            MoveButton(firstButton, secondButton, firstLeftPos, secondLeftPos);
        }

        private void MoveButton(Button firstButton, Button secondButton, double firstLeftPos, double secondLeftPos)
        {
            DoubleAnimation animationFirst = new(secondLeftPos - firstLeftPos, TimeSpan.FromMilliseconds(2000));
            var e = Canvas.GetLeft(firstButton);
            TranslateTransform transformFirst = new();
            firstButton.RenderTransform = transformFirst;

            transformFirst.BeginAnimation(TranslateTransform.XProperty, animationFirst);

            animationFirst.Completed += (sender, e) => anim_Completed(sender, e, firstButton, secondButton, firstLeftPos, secondLeftPos);
        }

        private void anim_Completed(object sender, EventArgs e, Button firstButton, Button secondButton, double firstLeftPos, double secondLeftPos)
        {
            Canvas.SetLeft(firstButton, secondLeftPos);
            Canvas.SetLeft(secondButton, firstLeftPos);
        }

        private (Button, Button) GetTwoRandonButtons()
        {
            Random rnd = new Random();

            var first = rnd.Next(3);

            var second = rnd.Next(3);

            while (first == second)
            {
                second = rnd.Next(3);
            }

            return (_buttons[first], _buttons[second]);
        }
    }
}