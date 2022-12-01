using LearnEnglish.Desktop.Interfaces;
using LearnEnglish.Shared.Dtos;

namespace LearnEnglish.Desktop.Presentation
{
    public partial class FrmCreateText : BaseForm
    {
        private readonly IHttpService _httpService;
        public FrmCreateText(IHttpService httpService, string text, bool isTranslate)
        {
            _httpService = httpService;
            InitializeComponent();
            if (!string.IsNullOrEmpty(text))
            {
                if (isTranslate)
                {
                    txt_translate.Text = text;
                    txt_value.Select();
                }
                else
                {
                    txt_value.Text = text;
                    txt_translate.Select();
                }
            }
        }

        private async void btn_create_Click(object sender, EventArgs e)
        {
            bool result = await _httpService.PostAsync("api/text/create", new CreateTextDto(txt_value.Text, txt_translate.Text));
            if (result)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("creation failed", "ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
