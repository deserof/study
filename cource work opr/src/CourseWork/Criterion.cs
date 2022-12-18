using System;
using System.Windows.Forms;

namespace CourseWork
{
    public class Criterion
    {
        public string Name { get; private set; }

        private int Count;
        public double IS { get; private set; }
        public double OS { get; private set; }
        public double Lambda { get; private set; }
        public double[] W_i { get; private set; }
        public string[,] Matrix { get; private set; }

        private double[] S;

        public bool flag { get; set; }

        public Criterion(string name, int count)
        {
            Name = name;
            Count = count;
            W_i = new double[Count];
            Matrix = new string[Count, Count];
            IS = OS = 0;
            Lambda = 0;
            S = new double[Count];
            flag = false;

            InitializeMatrix();
        }

        private void InitializeMatrix()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                Matrix[i, i] = "1";

                for (int j = i + 1; j < Count; j++)
                {
                    Matrix[i, j] = Matrix[j, i] = "0";
                }
            }

            Matrix[Count - 1, Count - 1] = "1";
        }

        public void UpdateMatrix(int i, int j, string value1, string value2)
        {
            Matrix[i, j] = value1;
            Matrix[j, i] = value2;
        }

        public bool ExploreMatrix()
        {
            double sum = 0;
            double[] V = new double[Count];
            double value;
            Lambda = 0;
            OS = 0;
            IS = 0;

            for (int i = 0; i < Count; i++)
            {
                V[i] = 1;
                S[i] = 0;

                for (int j = 0; j < Count; j++)
                {
                    value = ConvertToDouble(Matrix[j, i]);

                    if (value == 0) 
                    { 
                        return false; 
                    }

                    V[i] = V[i] * value;

                    value = ConvertToDouble(Matrix[i, j]);
                    if (value == 0) 
                    { 
                        return false;
                    }

                    S[i] = S[i] + ConvertToDouble(Matrix[i, j]);
                }

                V[i] = Math.Pow(V[i], 1 / (double)Count);
                sum += V[i];
            }

            for (int i = 0; i < Count; i++)
            {
                W_i[i] = V[i] / sum;
                Lambda += S[i] * W_i[i];
            }

            IS = Math.Round((Lambda - Count) / (Count - 1), 4);
            OS = Math.Round(IS / GetSI(), 4);

            return true;
        }

        private double ConvertToDouble(string value)
        {
            try
            {
                return Math.Round(double.Parse(value), 4);
            }
            catch
            {
                return Math.Round(double.Parse(value[0].ToString()) / double.Parse(value[2].ToString()), 4);
            }
        }

        private double GetSI()
        {
            switch (Count)
            {
                case 2:
                    return 0.00;
                case 3:
                    return 0.58;
                case 4:
                    return 0.90;
                case 5:
                    return 1.12;
                case 6:
                    return 1.24;
                case 7:
                    return 1.32;
                case 8:
                    return 1.41;
                case 9:
                    return 1.45;
                case 10:
                    return 1.49;
                case 11:
                    return 1.51;
                case 12:
                    return 1.48;
                case 13:
                    return 1.56;
                case 14:
                    return 1.57;
                case 15:
                    return 1.59;
                default:
                    return 0;
            }
        }

        public bool CheckExploring()
        {
            if (!flag)
            {
                MessageBox.Show("Исследуйте все матрицы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
