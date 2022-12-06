using LearnEnglish.Desktop.Models;
using LearnEnglish.Desktop.Services;

namespace LearnEnglish.Desktop.Presentation
{
    public partial class FrmNewKey : BaseForm
    {
        public Keys KeySelected { get; private set; }
        public FrmNewKey()
        {
            InitializeComponent();
            lbl_error.Visible = false;
            Text = "New Keyboard Key";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (KeySelected != Keys.None)
            {
                if (string.IsNullOrEmpty(txt_description.Text))
                {
                    MessageBox.Show("enter a friendly name");
                    return;
                }

                string textCustomKey = txt_description.Text.Trim().ToUpper();
                bool used = false;
                if (Enum.TryParse(textCustomKey, out Keys key))
                {
                    used = key.ToAvailableKey() != AvailableKey.None;
                }

                if (used || LocalStorage.Instancia.LocalStorageInfo.CustomKeys.Any(x => x.Description == textCustomKey))
                {
                    MessageBox.Show("friendly name is used for other key");
                    return;
                }

                LocalStorage.Instancia.LocalStorageInfo.CustomKeys.Add(new CustomKey
                {
                    Description = textCustomKey,
                    Key = KeySelected
                });
                await LocalStorage.Instancia.SaveChangesAsync();
                MessageBox.Show("key registered succesfull");
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void FrmNewKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_description.Focused)
            {
                return;
            }
            KeySelected = e.KeyCode;
            ShowKeyPress(e.KeyCode.ToString());
            if (e.KeyCode.ToAvailableKey() == AvailableKey.None && !LocalStorage.Instancia.LocalStorageInfo.CustomKeys.Any(x => x.Key == e.KeyCode))
            {
                lbl_error.Visible = false;
            }
            else
            {
                lbl_error.Visible = true;
            }

            lbl_key_pressed.Focus();
        }

        private void FrmNewKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_description.Focused)
            {
                return;
            }
            ShowKeyPress(e.KeyChar.ToString());
        }

        private void ShowKeyPress(string key)
        {
            if (key == "&") { key = "&&"; }
            lbl_key_pressed.Text = key;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            lbl_key_pressed.Focus();
        }

        private void lbl_key_pressed_Click(object sender, EventArgs e)
        {
            lbl_key_pressed.Focus();
        }
    }
}
