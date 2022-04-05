using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private const int MinValue = -100;
        private const int MaxValue = 100;
        private readonly Random _rnd = new Random();
        private int[,] _array;
        private int _arraySize;

        Dictionary<int, string> _sizes = new Dictionary<int, string>
        {
            {0,"Select"},
            {2,"2x2"},
            {3,"3x3"},
            {4,"4x4"},
            {5,"5x5"},
            {6,"6x6"},
            {7,"7x7"},
            {8,"8x8"},
            {9,"9x9"},
            {10,"10x10"}
        };

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = new BindingSource(_sizes, null);
            comboBox1.DisplayMember = "Value";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            _arraySize = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
            _array = new int[_arraySize, _arraySize];

            for (var i = 0; i < _arraySize; i++)
            {
                for (var j = 0; j < _arraySize; j++)
                {
                    _array[i, j] = _rnd.Next(MinValue, MaxValue);
                }
            }

            dataGridView1.ColumnCount = _arraySize;

            for (var i = 0; i < _arraySize; i++)
            {
                dataGridView1.Columns[i].Width = 40;
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                for (var j = 0; j < _arraySize; j++)
                {
                    row.Cells[j].Value = _array[i, j];
                }

                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_array is null || _array.Length == 0)
            {
                MessageBox.Show("Need to select size first", "Warning", MessageBoxButtons.OK);
                return;
            }

            Calc();
        }

        private void Calc()
        {
            var minValuesInRows = new int[_arraySize];
            var firstIndex = 0;

            for (var i = 0; i < _arraySize; i++)
            {
                var minValueInRow = _array[i, firstIndex];

                for (var j = 0; j < _arraySize; j++)
                {
                    if (_array[i, j] < minValueInRow)
                    {
                        minValueInRow = _array[i, j];
                    }
                }

                minValuesInRows[i] = minValueInRow;
            }

            var maxValue = minValuesInRows[0];

            for (var i = 0; i < minValuesInRows.Length; i++)
            {
                if (minValuesInRows[i] > maxValue)
                {
                    maxValue = minValuesInRows[i];
                }
            }

            var output = "Min values in rows:\n";

            for (var i = 0; i < minValuesInRows.Length; i++)
            {
                output += $"{i + 1}. {minValuesInRows[i]}\n";
            }

            output += $"Max value of min values: {maxValue}";

            MessageBox.Show(output, "Calc", MessageBoxButtons.OK);
        }
    }
}
