using lab8.Services.Interfaces;
using laba8;
using Microsoft.Extensions.DependencyInjection;

namespace lab8.Forms
{
    public partial class AccountForm : Form
    {
        private readonly IHttpService _httpService;

        public AccountForm(IServiceProvider serviceProvider)
        {
            _httpService = serviceProvider.GetRequiredService<IHttpService>();
            //_httpService.Send("");
            InitializeComponent();
        }

        private void adminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            userNameTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void userRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            userNameTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
        }
    }
}
