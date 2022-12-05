using Domain.Enums;
using Microsoft.VisualBasic.ApplicationServices;

namespace lab8.Forms
{
    public partial class UserForm : Form
    {
        private readonly IHttpService _httpService;
        private readonly IServiceProvider _serviceProvider;

        public UserForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _httpService = _serviceProvider.GetRequiredService<IHttpService>();
            InitializeComponent();

            InitData();

            positionCb.Items.AddRange(GetDescriptions<PositionType>().ToArray());

            nameTb.ReadOnly = true;
            lastNameTb.ReadOnly = true;
            passwordTb.ReadOnly = true;
            positionCb.Enabled = false;
            positionCb.DropDownStyle = ComboBoxStyle.DropDownList;
            positionCb.Text = Storage.CurrentUser.Position.GetDescription();
        }

        private void InitData()
        {
            nameTb.Text = Storage.CurrentUser.FirstName;
            lastNameTb.Text = Storage.CurrentUser.LastName;
            passwordTb.Text = Storage.CurrentUser.Password;
            positionCb.Text = Storage.CurrentUser.Position.GetDescription();
        }

        private void change_Click(object sender, EventArgs e)
        {
            nameTb.ReadOnly = false;
            lastNameTb.ReadOnly = false;
            passwordTb.ReadOnly = false;
            positionCb.Enabled = true;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Storage.CurrentUser.FirstName = nameTb.Text;
            Storage.CurrentUser.LastName = lastNameTb.Text;
            Storage.CurrentUser.Password = passwordTb.Text;
            Storage.CurrentUser.Position = GetEnumFromDescription<PositionType>(positionCb.Text);

            _httpService.Send(HttpMethod.Put, "https://localhost:7292/api/User", Storage.CurrentUser);

            Close();
        }
    }
}
