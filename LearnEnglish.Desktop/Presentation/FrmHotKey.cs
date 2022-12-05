using LearnEnglish.Desktop.Extensions;
using LearnEnglish.Desktop.Models;
using LearnEnglish.Desktop.Presentation.UserControls;
using LearnEnglish.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnEnglish.Desktop.Presentation
{
    public partial class FrmHotKey : BaseForm
    {
        private List<HotKeyAttribute> _hotKeys = new List<HotKeyAttribute>();
        public FrmHotKey()
        {
            InitializeComponent();
        }

        private void FrmHotKey_Load(object sender, EventArgs e)
        {
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

        private async void btn_save_changes_Click(object sender, EventArgs e)
        {
            GlobalHotKeyService.Instancia.HotKeys = new List<HotKeyAttribute>(_hotKeys);
            LocalStorage.Instancia.LocalStorageInfo.HotKeys = GlobalHotKeyService.Instancia.HotKeys;
            await LocalStorage.Instancia.SaveChangesAsync();
            MessageBox.Show("Hotkeys updated successfully", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
