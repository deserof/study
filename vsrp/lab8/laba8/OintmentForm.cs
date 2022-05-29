using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba8
{
    public partial class OintmentForm : Form
    {
        Ointment ointment;

        public OintmentForm(Ointment ointment)
        {
            InitializeComponent();

            this.ointment = ointment;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(comboBoxMinimalAge.Text, out int minimalAge) && (minimalAge == 6 || minimalAge == 10 || minimalAge == 18))
                && (int.TryParse(textBoxVolume.Text, out int volume) && volume > 0 && volume < 999))
            {
                ointment.ShelfLife = comboBoxShelfLife.Text;

                ointment.Title = comboBoxTitle.Text;

                ointment.MinimalAge = minimalAge;

                ointment.Country = comboBoxCountry.Text;

                ointment.Volume = volume;

                ointment.Type = comboBoxType.Text;
            }
            else
            {
                MessageBox.Show("Введите корректные значения");

                return;
            }

            Close();
        }
    }
}
