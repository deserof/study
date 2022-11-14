using lab8.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace lab8.Forms
{
    public partial class AccountForm : Form
    {
        private readonly IHttpService _httpService;

        public AccountForm(IServiceProvider serviceProvider)
        {
            _httpService = serviceProvider.GetRequiredService<IHttpService>();

            InitializeComponent();
        }

        private void adminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var response = _httpService.Send(HttpMethod.Get, "https://google.com");
            var coc = _httpService.Cookies;
        }

        private void authButton_Click(object sender, EventArgs e)
        {

        }
    }
}
