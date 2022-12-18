using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        int columnIndex = 0;
        int rowIndex = 0;
        ComboBox scaleComboBox = new ComboBox();

        public List<Criterion> criterionsList;
        public List<string> alternativesList;
        Criterion allCriterionsComparing;

        public List<double> WiList;

        public Form1(List<Criterion> criterionsFromElements, List<string> alternativesFromElements)
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            scaleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            criterionsList = new List<Criterion>();
            alternativesList = new List<string>();
            criterionsList.AddRange(criterionsFromElements.ToArray());
            alternativesList.AddRange(alternativesFromElements.ToArray());

            allCriterionsComparing = new Criterion("Object Criterions", criterionsList.Count);

            FillDataGrid();

            foreach(Criterion criteria in criterionsList)
            {
                criterionsComboBox.Items.Add(criteria.Name);
            }
        }

        private void FillDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Colunm0", "");
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            for (int i = 1; i < criterionsList.Count + 1; i++)
            {
                dataGridView1.Columns.Add("Сolumn" + i.ToString(), "");
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i - 1].Cells[0].ReadOnly = true;
            }

            ChangeDataGridHeaderText(elementComboBox.SelectedIndex);
            DataGridValueLoad(allCriterionsComparing);

            elementComboBox.SelectedIndex = 0;
        }

        private void DataGridValueLoad(Criterion element)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count; j++)
                {
                    if (element.Matrix[j - 1, i].Equals("0"))
                    {
                        dataGridView1.Rows[i].Cells[j].Value = "";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[j].Value = element.Matrix[j - 1, i];
                    }
                }
            }

            isTextBox.Text = element.IS.ToString();
            osTextBox.Text = element.OS.ToString();
            resultTextBox.Text = "";
        } 

        private void ChangeDataGridHeaderText(int index)
        {
            if (index > 0)
            {
                for (int i = 1; i < criterionsList.Count + 1; i++)
                {
                    dataGridView1.Columns[i].HeaderText = "A" + i.ToString();
                    dataGridView1.Rows[i - 1].Cells[0].Value = "A" + i.ToString();
                }

                label1.Visible = true;
                criterionsComboBox.Visible = true;
                criterionsComboBox.SelectedIndex = 0;
            }
            else if (index == 0)
            {
                for (int i = 1; i < criterionsList.Count + 1; i++)
                {
                    dataGridView1.Columns[i].HeaderText = "K" + i.ToString();
                    dataGridView1.Rows[i - 1].Cells[0].Value = "K" + i.ToString();
                }

                label1.Visible = false;
                criterionsComboBox.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scaleComboBox.Visible = false;

            string[] arrayItem = new string[17];
            for (int i = 0; i < 10; i++)
            {
                arrayItem[i] = (9 - i).ToString();
            }
            for (int i = 2; i < 10; i++)
            {
                arrayItem[i + 7] = ("1/" + i).ToString();
            }
            scaleComboBox.Items.AddRange(arrayItem);

            scaleComboBox.SelectedValueChanged += scaleComboBox_SelectedValueChanged;
            dataGridView1.Controls.Add(scaleComboBox);
        }

        private void scaleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (scaleComboBox.SelectedIndex == -1) 
            {
                return; 
            }

            if (elementComboBox.SelectedIndex == 0)
            {
                allCriterionsComparing.flag = false;
            }
            else 
            { 
                criterionsList[criterionsComboBox.SelectedIndex].flag = false; 
            }

            string newValue1 = scaleComboBox.SelectedItem.ToString();
            string newValue2 = scaleComboBox.Items[16 - scaleComboBox.SelectedIndex].ToString();

            dataGridView1[columnIndex, rowIndex].Value = newValue1;
            dataGridView1[rowIndex + 1, columnIndex - 1].Value = newValue2;

            scaleComboBox.Visible = false;

            if (elementComboBox.SelectedIndex == 0)
            {
                allCriterionsComparing.UpdateMatrix(columnIndex - 1, rowIndex, newValue1, newValue2);
            } 
            else
            {
                criterionsList[criterionsComboBox.SelectedIndex].UpdateMatrix(
                    columnIndex - 1, rowIndex, newValue1, newValue2);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            columnIndex = e.ColumnIndex;

            if (columnIndex == 0 || (columnIndex - 1) == rowIndex)
            { 
                return;
            }

            //Получаем прямоугольник ячейки
            Rectangle rectangle = dataGridView1.GetCellDisplayRectangle(columnIndex, rowIndex, true);

            //Задаем размеры и месторасположение
            scaleComboBox.Size = new Size(rectangle.Width, rectangle.Height);
            scaleComboBox.Location = new Point(rectangle.X, rectangle.Y);

            //Меняем индекс на изначальный (чтобы значение предыдущей ячейки не тянулось в следующие)
            scaleComboBox.SelectedIndex = -1;

            scaleComboBox.Visible = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            scaleComboBox.Visible = false;
        }

        private void criterionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridValueLoad(criterionsList[criterionsComboBox.SelectedIndex]);
            dataGridView1.Enabled = true;
        }

        private void elementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDataGridHeaderText(elementComboBox.SelectedIndex);

            if (elementComboBox.SelectedIndex == 0)
            {
                DataGridValueLoad(allCriterionsComparing);
            }
            else
            {
                DataGridValueLoad(criterionsList[criterionsComboBox.SelectedIndex]);
            }
        }

        private void exploreButton_Click(object sender, EventArgs e)
        {
            Criterion element;
            if (elementComboBox.SelectedIndex == 0) 
            { 
                element = allCriterionsComparing;
            }
            else 
            { 
                element = criterionsList[criterionsComboBox.SelectedIndex];
            }

            if (!element.ExploreMatrix())
            {
                MessageBox.Show("Введите все значения!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                isTextBox.Text = element.IS.ToString();
                osTextBox.Text = element.OS.ToString();

                if (element.OS < 0.1) 
                {
                    resultTextBox.Text = "Матрица согласована, т.к. ОС < 0.1"; 
                }
                else 
                { 
                    resultTextBox.Text = "Матрица не согласована, т.к. ОС > 0.1";
                
                }
            }

            if (elementComboBox.SelectedIndex == 0) 
            { 
                allCriterionsComparing.flag = true;
            }
            else 
            { 
                criterionsList[criterionsComboBox.SelectedIndex].flag = true;
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if(!allCriterionsComparing.CheckExploring()) 
            { 
                return; 
            }

            foreach(Criterion element in criterionsList)
            {
                if(!element.CheckExploring())
                {
                    return; 
                }
            }

            WiList = new List<double>();
            double W = 0;

            try
            {
                for (int i = 0; i < criterionsList.Count; i++)
                {
                    for (int j = 0; j < criterionsList.Count; j++)
                    {
                        W += allCriterionsComparing.W_i[j] * criterionsList[j].W_i[i];
                    }

                    WiList.Add(Math.Round(W, 4));
                    W = 0;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ResultForm resultForm = new ResultForm();
            resultForm.Owner = this;
            resultForm.Show();
        }
    }
}
