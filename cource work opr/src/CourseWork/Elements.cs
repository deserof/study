using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Elements : Form
    {
        Form1 mainForm;
        List<Criterion> criterionsList;
        List<string> alternativesList; 

        public Elements()
        {
            InitializeComponent();
            criterionsList = new List<Criterion>();
            alternativesList = new List<string>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddRows(CriterionsDataGridView, ElementsCountComboBox.SelectedIndex);
            AddRows(AlternativesDataGridView, ElementsCountComboBox.SelectedIndex);
        }

        private void AddRows(DataGridView dataGridView, int count)
        {
            dataGridView.Rows.Clear();
            dataGridView.Rows.Add(count + 2);

            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[0].Value = row.Index + 1;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!CreateNewElements())
            { 
                return; 
            }

            mainForm = new Form1(criterionsList, alternativesList);
            mainForm.ShowDialog();
        }

        private bool CreateNewElements()
        {
            foreach (DataGridViewRow row in CriterionsDataGridView.Rows)
            {
                if (!CheckInput(row))
                { 
                    return false; 
                }

                Criterion criterion = new Criterion(row.Cells[1].Value.ToString(), CriterionsDataGridView.Rows.Count);
                criterionsList.Add(criterion);
            }

            foreach (DataGridViewRow row in AlternativesDataGridView.Rows)
            {
                if (!CheckInput(row))
                { 
                    return false; 
                }

                alternativesList.Add(row.Cells[1].Value.ToString());
            }

            return true;
        }

        private bool CheckInput(DataGridViewRow dataGridViewRow)
        {
            if (dataGridViewRow.Cells[1].Value == null)
            {
                MessageBox.Show("Введите все названия элементов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }
    }
}
