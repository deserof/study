﻿using lab8.Models.Enums;
using laba8.Models.Entities;
using static lab8.Extensions.EnumExtension;

namespace laba8
{
    public partial class OintmentForm : Form
    {
        private readonly Ointment _ointment;

        public OintmentForm(Ointment ointment)
        {
            InitializeComponent();

            comboBoxType.Items.AddRange(GetDescriptions<OitmentType>().ToArray());
            comboBoxType.SelectedIndex = 0;

            comboBoxMinimalAge.Items.AddRange(GetDescriptions<MinimalAgeType>().ToArray());
            comboBoxMinimalAge.SelectedIndex = 0;

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
                _ointment.OitmentType = comboBoxType.Text;
            }
            else
            {
                MessageBox.Show("Введите корректные значения");

                return;
            }

            Close();
        }

        private void OintmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
