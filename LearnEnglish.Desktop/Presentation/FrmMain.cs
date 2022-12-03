using LearnEnglish.Desktop.Extensions;
using LearnEnglish.Desktop.Factorys;
using LearnEnglish.Desktop.Interfaces;
using LearnEnglish.Shared.Dtos;
using System.Web;

namespace LearnEnglish.Desktop.Presentation
{
    public partial class FrmMain : BaseForm
    {
        private bool isTranslated = true;
        private readonly IHttpService _httpService;
        private readonly FrmCreateTextFactory _frmCreateTextFactory;

        public FrmMain(FrmCreateTextFactory frmCreateTextFactory, IHttpService httpService)
        {
            _httpService = httpService;
            _frmCreateTextFactory = frmCreateTextFactory;
            InitializeComponent();
            dg_result.RoundBorder();
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
            txt_filter.Select();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            _frmCreateTextFactory.Create(txt_filter.Text, isTranslated).ShowDialog();
        }


        private async void txt_filter_TextChanged(object sender, EventArgs e)
        {
            var result = await _httpService.GetAsync<List<TextDto>>($"api/text/filter?text={HttpUtility.UrlEncode(txt_filter.Text)}&translated={isTranslated}");
            dg_result.Rows.Clear();
            foreach (var item in result)
            {
                int index = dg_result.Rows.Add();
                dg_result.Rows[index].Cells[column_value.Name].Value = item.Value;
                dg_result.Rows[index].Cells[column_translate.Name].Value = item.Translate;
                dg_result.Rows[index].Cells[column_last_update.Name].Value = item.CreationDate.ToLocalTime();
                dg_result.Rows[index].Cells[column_details.Name].Value = "Edit";
            }
        }
    }
}