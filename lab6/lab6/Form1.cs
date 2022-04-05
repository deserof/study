using lab6.Services.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab6
{
    public partial class Lab6 : Form
    {
        private readonly ITextService _textService;
        private readonly IHistoryService _historyService;

        public Lab6(
            ITextService textService,
            IHistoryService historyService)
        {
            _textService = textService;
            _historyService = historyService;
            InitializeComponent();
            InputText.Text = _textService.GetText();
            InputText_TextChanged(new object(), EventArgs.Empty);
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            FontValue.Text = InputText.Font.Name;
            SymbolsValue.Text = InputText.Text.Length.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateValue.Text = DateTime.Now.ToString("F");
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (_textService.TryGetStartAndLengthSubstringIndex(FindText.Text, out int startIndex, out int length))
            {
                InputText.SelectionStart = startIndex;
                InputText.SelectionLength = length;
                InputText.SelectionColor = Color.DarkGoldenrod;
            }
            else
            {
                MessageBox.Show($"Text not found: {FindText.Text}");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputText.SelectionStart = 0;
            InputText.SelectionLength = InputText.Text.Length;
            InputText.SelectionColor = Color.Black;
        }

        private void FindAndReplaceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FindText2.Text) || string.IsNullOrEmpty(ReplaceText.Text))
            {
                MessageBox.Show("Enter text");
                return;
            }

            string text = _textService.ReplaceText(FindText2.Text, ReplaceText.Text);
            InputText.Text = text;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RemoveText.Text))
            {
                MessageBox.Show("Enter text");
                return;
            }

            string text = _textService.RemoveText(RemoveText.Text);
            InputText.Text = text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _textService.SaveText(InputText.Text);
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            History historyForm = new History(_historyService);
            historyForm.Show();
        }
    }
}
