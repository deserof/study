using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        private double[] _array;
        private double[] _sortedArray;
        private readonly object[] _range = new object[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        private readonly Random _rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(_range);
            dataGridView1.Columns.Add("Arrays", "Arrays");
            dataGridView1.Columns[0].Width = 400;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            int length = (int)comboBox1.SelectedItem;
            _array = new double[length];

            for (int i = 0; i < length; i++)
            {
                _array[i] = _rnd.Next(-10, 30) / 10.0;
            }

            dataGridView1.Rows.Add(string.Join(" ", _array));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_array is null)
            {
                MessageBox.Show("Need to select size first", "Warning", MessageBoxButtons.OK);
                return;
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(string.Join(" ", _array));

            double minValueIndex = 0;
            double sumBetweenFirstAndSecondNegative = 0;
            double minValue = _array[0];

            for (int i = 0; i < _array.Length; i++)
            {
                if (minValue > _array[i])
                {
                    minValue = _array[i];
                    minValueIndex = i;
                }
            }

            int state = 0;
            bool flag = true;

            for (var i = 0; i < _array.Length; i++)
            {
                if (_array[i] < 0)
                {
                    state++;
                }

                if (state == 2)
                {
                    flag = false;
                    break;
                }

                if (_array[i] >= 0 && state == 1)
                {
                    sumBetweenFirstAndSecondNegative += _array[i];
                }
            }

            if (flag)
            {
                sumBetweenFirstAndSecondNegative = 0;
            }

            _sortedArray = (double[])_array.Clone();

            for (var i = 0; i < _sortedArray.Length; i++)
            {
                if (Math.Abs(_sortedArray[i]) <= 1)
                {
                    continue;
                }

                for (var j = i + 1; j < _sortedArray.Length; j++)
                {
                    if (Math.Abs(_sortedArray[j]) <= 1)
                    {
                        (_sortedArray[j], _sortedArray[i]) = (_sortedArray[i], _sortedArray[j]);
                    }
                }
            }

            dataGridView1.Rows.Add(string.Join(" ", _sortedArray));

            MessageBox.Show($"1. Номер минимального элемента массива: {minValueIndex}, Элемент: {minValue}\n" +
                    $"2. Сумма элементов массива, расположенных между первым и вторым отрицательным" +
                    $" элементами: {Math.Round(sumBetweenFirstAndSecondNegative, 2)}");
        }
    }
}
