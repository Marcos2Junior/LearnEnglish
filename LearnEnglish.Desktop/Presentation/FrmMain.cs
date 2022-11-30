using LearnEnglish.Desktop.Factorys;
using LearnEnglish.Desktop.Interfaces;
using LearnEnglish.Shared.Dtos;
using System.Web;

namespace LearnEnglish.Desktop.Presentation
{
    public partial class FrmMain : Form
    {
        private bool isTranslated = true;
        private readonly IHttpService _httpService;
        private readonly FrmCreateTextFactory _frmCreateTextFactory;

        public FrmMain(FrmCreateTextFactory frmCreateTextFactory, IHttpService httpService)
        {
            _httpService = httpService;
            _frmCreateTextFactory = frmCreateTextFactory;
            InitializeComponent();
        }

        private void btn_change_translate_Click(object sender, EventArgs e) => ChangeTranslate();

        private void ChangeTranslate()
        {
            isTranslated = !isTranslated;
            string description = "What would you like to translate from ";
            if (isTranslated)
            {
                lbl_description.Text = $"{description}Portuguese?";
                btn_change_translate.Text = "Portuguese to English";
            }
            else
            {
                lbl_description.Text = $"{description}English?";
                btn_change_translate.Text = "English to Portuguese";
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ChangeTranslate();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            _frmCreateTextFactory.Create(txt_filter.Text, isTranslated).ShowDialog();
        }

        private async void txt_filter_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private async void txt_filter_KeyDown(object sender, KeyEventArgs e)
        {
            var result = await _httpService.GetAsync<List<TextDto>>($"api/text/filter?text={HttpUtility.UrlEncode(txt_filter.Text)}&translated={isTranslated}");
            BindingSource bs = new()
            {
                DataSource = (from r in result select isTranslated ? r.Value : r.Translate).ToList()
            };
            txt_filter.DataSource = bs;
        }
    }
}