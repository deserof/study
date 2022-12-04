using Microsoft.Extensions.DependencyInjection;

namespace lab8.Forms
{
    public partial class AccountForm : Form
    {
        private readonly IHttpService _httpService;
        private readonly IServiceProvider _serviceProvider;
        public AccountForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _httpService = serviceProvider.GetRequiredService<IHttpService>();

            InitializeComponent();

            var users = _httpService.Send<List<UserModel>>(HttpMethod.Get, "https://localhost:7292/api/User");

            userRadioButton.Checked = true;
            usersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            usersComboBox.Items.AddRange(users.Select(x=>x.LastName).ToArray());
            usersComboBox.SelectedIndex = 0;
        }

        private void adminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usersComboBox.Enabled = true;
            passwordTextBox.Enabled = true;
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (adminRadioButton.Checked)
            {
                var requestModel = new UserLoginRequestModel
                {
                    LastName = usersComboBox.Text,
                    Password = passwordTextBox.Text
                };

                var response = _httpService.Send<UserModel, UserLoginRequestModel>(HttpMethod.Post, "https://localhost:7292/api/Account", requestModel);

                if (response.FirstName == null && response.LastName == null)
                {
                    MessageBox.Show("Invalid credentials!!!");
                    return;
                }

                Storage.CurrentUser = response;
            }

            var mainForm = new MainForm(_serviceProvider);
            this.Hide();
            mainForm.ShowDialog();
        }

        private void userRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usersComboBox.Enabled = false;
            passwordTextBox.Enabled = false;
        }
    }
}
