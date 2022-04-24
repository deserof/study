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
        private string _buffer;

        public Lab6(
            ITextService textService,
            IHistoryService historyService)
        {
            _textService = textService;
            _historyService = historyService;
            InitializeComponent();
            InputText.ContextMenuStrip = contextMenuStrip4;
            InputText.Text = _textService.GetText();
            InputText_TextChanged(new object(), EventArgs.Empty);
            base.KeyPreview = true;
        }

        private void toolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            _buffer = InputText.SelectedText;
            InputText.Cut();
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e) =>
            _buffer = InputText.SelectedText;

        private void toolStripMenuItemInsert_Click(object sender, EventArgs e)
        {
            var myFormat = DataFormats.GetFormat(_buffer);
            InputText.Paste(myFormat);
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            FontValue.Text = InputText.Font.Name;
            SymbolsValue.Text = InputText.Text.Length.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e) => DateValue.Text = DateTime.Now.ToString("F");

        private void FindButton_Click(object sender, EventArgs e)
        {
            InputText.SelectionStart = 0;
            InputText.SelectionLength = InputText.TextLength;
            InputText.SelectionColor = Color.Black;

            if (FindText.Text == "")
            {
                MessageBox.Show($"Text not found: {FindText.Text}");
            }

            int startIndex = 0;
            int index;
            while ((index = InputText.Text.IndexOf(FindText.Text, startIndex, StringComparison.Ordinal)) != -1)
            {
                InputText.Select(index, FindText.Text.Length);
                InputText.SelectionColor = Color.Coral;
                startIndex = index + FindText.Text.Length;
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

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Student: Artsiom Kharkevich\nVariant 8";
            MessageBox.Show(message, "about", MessageBoxButtons.OK);
        }

        private void magneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Font = new Font("Magneto", 10f);
        }

        private void segoeUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Font = new Font("Segoe UI", 10f);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Font = new Font("Times New Roman", 10f);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InputText.Font = new Font(InputText.Font.Name, 8f);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            InputText.Font = new Font(InputText.Font.Name, 10f);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            InputText.Font = new Font(InputText.Font.Name, 12f);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            InputText.Font = new Font(InputText.Font.Name, 14f);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //    if (e.Control && e.KeyCode == Keys.Q)
            //    {
            //        buffer = InputText.SelectedText;
            //        InputText.SelectedText = string.Empty;
            //        return;
            //    }

            //    if (e.Control && e.KeyCode == Keys.W)
            //    {
            //        buffer = InputText.SelectedText;
            //        return;
            //    }

            //    if (e.Control && e.KeyCode == Keys.RControlKey)
            //    {
            //        InputText.SelectedText = buffer;
            //        return;
            //    }
        }

        private void upperCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text.ToUpper();
        }

        private void lowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text.ToLower();
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Text = _textService.SetStandartCaseForText();
        }

        private bool _prev = false;
        private bool _prevPrev = false;

        private void RichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == '!' || e.KeyChar == '?')
            {
                _prevPrev = true;
                return;
            }

            if (e.KeyChar == ' ')
            {
                _prev = true;
                return;
            }

            if (_prev && _prevPrev)
            {
                e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
                _prevPrev = false;
                _prev = false;
                return;
            }

            e.KeyChar = char.Parse(e.KeyChar.ToString().ToLower());
        }
    }
}
