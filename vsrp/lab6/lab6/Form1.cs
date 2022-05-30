using lab6.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab6
{
    public partial class Lab6 : Form
    {
        private readonly ITextService _textService;
        private readonly IHistoryService _historyService;
        private string _buffer;
        private bool IsUpper;
        private bool IsLower;
        private bool _prev;
        private bool _prevPrev;

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
            var t = new ToolTip();
            t.SetToolTip(variant8Button,
                @"Записать каждое предложение текста в порядке возрастания количества гласных букв в слове.");
            t.SetToolTip(variant8_2btn, @"Вывести все слова из текста, которые встречаются два и более раз.");
        }

        private void toolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            _buffer = InputText.SelectedText;
            InputText.Copy();
            InputText.Cut();
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            InputText.Copy();
            _buffer = InputText.SelectedText;
        }


        private void toolStripMenuItemInsert_Click(object sender, EventArgs e)
        {
            InputText.Paste();
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = InputText.Font.Name;
            toolStripStatusLabel1.Text = InputText.Text.Length.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e) => toolStripStatusLabel1.Text = DateTime.Now.ToString("F");

        private void FindButton_Click(object sender, EventArgs e)
        {
            InputText.SelectionStart = 0;
            InputText.SelectionLength = InputText.TextLength;
            InputText.SelectionColor = Color.Black;

            if (FindText.Text == "")
            {
                MessageBox.Show($"Text not found: {FindText.Text}");
                return;
            }

            int startIndex = 0;
            int index;

            if (checkCaseCheckBox1.Checked)
            {
                while ((index = InputText.Text.IndexOf(FindText.Text, startIndex, StringComparison.Ordinal)) != -1)
                {
                    InputText.Select(index, FindText.Text.Length);
                    InputText.SelectionColor = Color.Coral;
                    startIndex = index + FindText.Text.Length;
                }
            }
            else
            {
                while ((index = InputText.Text.ToLower().IndexOf(FindText.Text.ToLower(), startIndex, StringComparison.Ordinal)) != -1)
                {
                    InputText.Select(index, FindText.Text.Length);
                    InputText.SelectionColor = Color.Coral;
                    startIndex = index + FindText.Text.Length;
                }
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

            string text = checkCaseCheckBox2.Checked 
                ? _textService.ReplaceText(FindText2.Text, ReplaceText.Text) 
                : _textService.ReplaceText(FindText2.Text.ToLower(), ReplaceText.Text.ToLower());

            InputText.Text = text;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RemoveText.Text))
            {
                MessageBox.Show("Enter text");
                return;
            }

            string text = checkCaseCheckBox2.Checked
                ? _textService.RemoveText(RemoveText.Text)
                : _textService.RemoveText(RemoveText.Text.ToLower());

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

        }

        private void upperCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text.ToUpper();
            IsUpper = true;
            IsLower = false;
        }

        private void lowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text.ToLower();
            IsLower = true;
            IsUpper = false;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.Text = _textService.SetStandartCaseForText();

            IsLower = false;
            IsUpper = false;
        }

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

            if (IsLower)
            {
                e.KeyChar = char.Parse(e.KeyChar.ToString().ToLower());
            }

            if (IsUpper)
            {
                e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
            }
        }

        private void variant8Button_Click(object sender, EventArgs e)
        {
            char[] vowels = {'а','у','е','о','ы','э','ю','я'};
            List<string> sents = new List<string>(_textService.GetText().Split(new []{'.', '!', '?'}));
            List<string> lenOfVowels = new List<string>();

            foreach (var sent in sents)
            {
                int count = 0;

                foreach (var vowel in vowels)
                {
                    foreach (var sym in sent)
                    {
                        if (char.ToLower(sym) == vowel)
                        {
                            count++;
                        }
                    }
                }

                lenOfVowels.Add($"{GenerateRandomNumber()}_{count}");
            }

            var dict = lenOfVowels
                .Zip(sents, (k, v) => new { k, v })
                .ToDictionary(x => x.k, x => x.v);

            var sortedDict = dict.OrderBy(x => Convert.ToInt32(x.Key[5..]));
            var txt = new StringBuilder();

            foreach (var t in sortedDict)
            {
                txt.Append($"{Convert.ToInt32(t.Key[5..])} {t.Value}\n");
            }

            MessageBox.Show(txt.ToString());
        }

        private int GenerateRandomNumber()
        {
            int _min = 1000;
            int _max = 9999;
            var _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputText.Text = _textService.GetText();
        }

        private void FindLiteralButton_Click(object sender, EventArgs e)
        {
            if (LiteralTextBox.Text.Length == 0)
            {
                MessageBox.Show("Error");
                return;
            }

            MessageBox.Show(_textService.FindLiteral(LiteralTextBox.Text));
        }

        private void variant8_2btn_Click(object sender, EventArgs e)
        {
            int count;
            List<string> list = new List<string>();
            string temp = "";

            string text = _textService.GetText();
            string[] writes = new string(text.Where(c => !char.IsPunctuation(c)).ToArray()).Split(' ');

            foreach (var t in writes)
            {
                count = 0;
                if (temp == t) continue;

                foreach (string word in writes)
                {
                    if (t == word) count++;

                    if (count <= 2) continue;

                    list.Add(t);
                    temp = t;
                    break;
                }
            }

            var strBldr = new StringBuilder();
            List<string> uniqueWords = list.Distinct().ToList();
            foreach (string l in uniqueWords) strBldr.Append($"{l}\n");

            MessageBox.Show(strBldr.ToString());
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
