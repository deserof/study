using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            Form1 mainform = Owner as Form1;

            for (int i = 0; i < mainform.criterionsList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = mainform.alternativesList[i];
                dataGridView1.Rows[i].Cells[1].Value = mainform.WiList[i];

                chart1.Series[0].Points.AddXY(mainform.alternativesList[i], mainform.WiList[i]);
            }
        }
    }
}
