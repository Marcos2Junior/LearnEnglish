using LearnEnglish.Desktop.Models;
using LearnEnglish.Desktop.Presentation.UserControls;
using LearnEnglish.Desktop.Services;

namespace LearnEnglish.Desktop.Presentation
{
    public partial class FrmHotKey : BaseForm
    {
        private List<HotKeyAttribute> _hotKeys = new List<HotKeyAttribute>();
        public FrmHotKey()
        {
            InitializeComponent();
            Text = "Keyboard shortcuts";
        }

        private void FrmHotKey_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private async void btn_save_changes_Click(object sender, EventArgs e)
        {
            GlobalHotKeyService.Instancia.HotKeys = new List<HotKeyAttribute>(_hotKeys);
            LocalStorage.Instancia.LocalStorageInfo.HotKeys = GlobalHotKeyService.Instancia.HotKeys;
            await LocalStorage.Instancia.SaveChangesAsync();
            MessageBox.Show("Hotkeys updated successfully", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_add_key_Click(object sender, EventArgs e)
        {
            if(new FrmNewKey().ShowDialog() == DialogResult.OK)
            {
                LoadForm();
            }
        }

        private void LoadForm()
        {
            p_main.Controls.Clear();
            foreach (HotKeyAttribute hotkey in GlobalHotKeyService.Instancia.HotKeys)
            {
                var newHotKey = new HotKeyAttribute(hotkey.HotKeyType, hotkey.DescriptionKey, hotkey.Key1, hotkey.Key2, hotkey.Key3);
                _hotKeys.Add(newHotKey);
                var control = new SelectHotKeyControl(newHotKey)
                {
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 0, 0, 20)
                };
                p_main.Controls.Add(control);
            }
        }
    }
}
