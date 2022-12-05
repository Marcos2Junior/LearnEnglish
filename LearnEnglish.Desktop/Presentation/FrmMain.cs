using LearnEnglish.Desktop.Extensions;
using LearnEnglish.Desktop.Factorys;
using LearnEnglish.Desktop.Interfaces;
using LearnEnglish.Desktop.Services;
using LearnEnglish.Shared.Dtos;
using System.Web;

namespace LearnEnglish.Desktop.Presentation
{
    public partial class FrmMain : BaseForm
    {
        private bool isTranslated = true;
        private readonly IHttpService _httpService;
        private readonly FrmCreateTextFactory _frmCreateTextFactory;
        private CancellationTokenSource cts;

        public FrmMain(FrmCreateTextFactory frmCreateTextFactory, IHttpService httpService)
        {
            _httpService = httpService;
            _frmCreateTextFactory = frmCreateTextFactory;
            InitializeComponent();
            dg_result.RoundBorder();

            int percent = dg_result.Width / 100;
            int widthValue = percent * 40;
            int widthTranslate = percent * 40;
            int widthLastUpdate = dg_result.Width - widthValue - widthTranslate;
            dg_result.Columns[column_value.Name].Width = widthValue;
            dg_result.Columns[column_translate.Name].Width = widthTranslate;
            dg_result.Columns[column_last_update.Name].Width = widthLastUpdate;
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

            txt_filter.Select();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ChangeTranslate();
        }

        private void btn_create_Click(object sender, EventArgs e) => CreateNewTranslate();

        private void CreateNewTranslate()
        {
            _frmCreateTextFactory.Create(txt_filter.Text, isTranslated).ShowDialog();

        }

        private async void txt_filter_TextChanged(object sender, EventArgs e)
        {
            dg_result.Rows.Clear();
            cts?.Cancel();
            cts = new CancellationTokenSource();
            var result = await _httpService.GetAsync<List<TextDto>>($"api/text/filter?text={HttpUtility.UrlEncode(txt_filter.Text)}&translated={isTranslated}", cts.Token);
            if (result != null)
            {
                foreach (var item in result)
                {
                    int index = dg_result.Rows.Add();
                    dg_result.Rows[index].Cells[column_value.Name].Value = item.Value;
                    dg_result.Rows[index].Cells[column_translate.Name].Value = item.Translate;
                    dg_result.Rows[index].Cells[column_last_update.Name].Value = item.CreationDate.ToLocalTime();
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void txt_filter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void FrmMain_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                txt_filter.Select();
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (GlobalHotKeyService.Instancia.HotKeyMatch(e.KeyCode))
            {
                case Models.HotKeyType.ChangeTranslate:
                    ChangeTranslate();
                    break;
                case Models.HotKeyType.CreateNewTranslate:
                    CreateNewTranslate();
                    break;
                default:
                    break;
            }
        }
    }
}