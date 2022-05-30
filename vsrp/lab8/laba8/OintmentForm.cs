using System;
using System.Windows.Forms;

namespace laba8
{
    public partial class OintmentForm : Form
    {
        private readonly Ointment _ointment;

        public OintmentForm(Ointment ointment)
        {
            InitializeComponent();

            _ointment = ointment;
        }

        private void buttonSetData_Click(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxMinimalAge.Text, out int minimalAge) 
                && (minimalAge == 6 || minimalAge == 10 || minimalAge == 18)
                && int.TryParse(textBoxVolume.Text, out int volume) 
                && volume > 0 && volume < 999)
            {
                _ointment.ShelfLife = comboBoxShelfLife.Text;
                _ointment.Title = comboBoxTitle.Text;
                _ointment.MinimalAge = minimalAge;
                _ointment.Country = comboBoxCountry.Text;
                _ointment.Volume = volume;
                _ointment.Type = comboBoxType.Text;
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
