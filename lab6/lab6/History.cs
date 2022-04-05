using lab6.Services.Interfaces;
using System.Windows.Forms;

namespace lab6
{
    public partial class History : Form
    {
        private readonly IHistoryService _historyService;

        public History(IHistoryService historyService)
        {
            this._historyService = historyService;
            InitializeComponent();
            ShowHistory();
        }

        private void ShowHistory()
        {
            RemoveHistoryText.Text = _historyService.GetRemoveHistory();
            ReplaceHistoryText.Text = _historyService.GetReplaceHistory();
        }
    }
}
