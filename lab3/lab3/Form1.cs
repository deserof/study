using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<int, string> _rainbowRus = new Dictionary<int, string>
        {
            {1,"красный"},
            {2,"оранжевый"},
            {3,"желтый"},
            {4,"зеленый" },
            {5,"голубой" },
            {6,"синий"},
            {7,"фиолетовый" },
        };

        private readonly Dictionary<int, string> _rainbowEng = new Dictionary<int, string>
        {
            {1, "red" },
            {2, "orange" },
            {3, "yellow" },
            {4, "green" },
            {5, "blue" },
            {6, "indigo" },
            {7, "purple" },
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            string color = string.Empty;

            while (!int.TryParse(textBox1.Text, out number))
            {
                textBox1.Text = string.Empty;
                MessageBox.Show("Error input");
                return;
            }

            if (radioButton1.Checked)
            {
                _rainbowRus.TryGetValue(number, out color);
            }
            else
            {
                _rainbowEng.TryGetValue(number, out color);
            }

            if (string.IsNullOrEmpty(color))
            {
                MessageBox.Show("Color does not exist");
                return;
            }

            MessageBox.Show($"Color is {color}");
        }
    }
}
