using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace lab9
{
    public partial class Form1 : Form
    {
        private List<TaskZavod> taskZavods = new();

        public Form1()
        {
            InitializeComponent();

            timeFirstLabel.Text = string.Empty;
            timeSecondLabel.Text = string.Empty;

            commonTimeFirst.Text = string.Empty;
            commonTimeSecond.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sumsFirst = new int[taskZavods.Count];

            for (int i = 0; i < taskZavods.Count; i++)
            {
                if (i == 0)
                {
                    sumsFirst[i] = taskZavods[i].A;
                }

                if (i != 0 && i < taskZavods.Count)
                {
                    sumsFirst[i] = sumsFirst[i - 1] + taskZavods[i].A - taskZavods[i - 1].B;
                }
            }

            int maxFirst = 0;

            for (int i = 0; i < taskZavods.Count; i++)
            {
                if (sumsFirst[i] > maxFirst)
                {
                    maxFirst = sumsFirst[i];
                }
            }

            timeFirstLabel.Text = maxFirst.ToString();

            List<TaskZavod> sortedTaskZavod = new(taskZavods);
            sortedTaskZavod.Sort(new TasksComparer());

            int[] sumsSecond = new int[taskZavods.Count];

            for (int i = 0; i < taskZavods.Count; i++)
            {
                if (i == 0)
                {
                    sumsSecond[i] = sortedTaskZavod[i].A;
                }

                if (i != 0 && i < taskZavods.Count)
                {
                    sumsSecond[i] = sumsSecond[i - 1] + sortedTaskZavod[i].A - sortedTaskZavod[i - 1].B;
                }
            }

            int maxSecond = 0;

            for (int i = 0; i < taskZavods.Count; i++)
            {
                if (sumsSecond[i] > maxSecond) maxSecond = sumsSecond[i];
            }

            timeSecondLabel.Text = maxSecond.ToString();

            int a = sumsFirst[0];
            for (int i = 0; i < taskZavods.Count - 1; i++)
            {
                if (taskZavods[i].B > taskZavods[i + 1].A)
                {
                    a += taskZavods[i].B;
                }
                else a += taskZavods[i + 1].A;
            }

            int b = sumsSecond[0];
            for (int i = 0; i < sortedTaskZavod.Count - 1; i++)
            {
                if (sortedTaskZavod[i].B > sortedTaskZavod[i + 1].A)
                {
                    b += sortedTaskZavod[i + 1].A;
                }
                else b += sortedTaskZavod[i].B;
            }

            commonTimeFirst.Text = a.ToString();
            commonTimeSecond.Text = b.ToString();

            FillDataGridView(dataGridView2, sortedTaskZavod);
        }

        private void ReadExcel()
        {
            taskZavods.Clear();

            string filePath = string.Empty;

            OpenFileDialog openFileDialog = new();
            string workingDirectory = Environment.CurrentDirectory;
            openFileDialog.InitialDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = Path.GetFullPath(openFileDialog.FileName);
            }

            XSSFWorkbook hssfwb;

            try
            {
                using (FileStream file = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    hssfwb = new(file);
                }
            }
            catch
            {
                MessageBox.Show("Неправильный файл");
                return;
            }

            ISheet sheet = hssfwb.GetSheet("Sheet1");

            for (int row = 1; row <= sheet.LastRowNum; row++)
            {
                TaskZavod taskZavod = new()
                {
                    Number = (int)sheet.GetRow(row).Cells[0].NumericCellValue,
                    A = (int)sheet.GetRow(row).Cells[1].NumericCellValue,
                    B = (int)sheet.GetRow(row).Cells[2].NumericCellValue
                };

                taskZavods.Add(taskZavod);
            }
        }

        private void FillDataGridView(DataGridView dataGridView, List<TaskZavod> taskZavods)
        {
            dataGridView.Rows.Clear();

            for (int i = 0; i < taskZavods.Count; i++)
            {
                dataGridView.Rows.Add(new string[3]
                {
                    taskZavods[i].Number.ToString(),
                    taskZavods[i].A.ToString(),
                    taskZavods[i].B.ToString()
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadExcel();

            FillDataGridView(dataGridView1, taskZavods);

            timeFirstLabel.Text = string.Empty;
            timeSecondLabel.Text = string.Empty;
        }
    }

    public class TasksComparer : IComparer<TaskZavod>
    {
        public int Compare(TaskZavod? x, TaskZavod? y)
        {
            if (Math.Min(x.A, y.B) <= Math.Min(y.A, x.B))
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}