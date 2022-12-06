using LearnEnglish.Desktop.Extensions;
using LearnEnglish.Desktop.Helpers;
using LearnEnglish.Desktop.Models;
using LearnEnglish.Desktop.Properties;
using LearnEnglish.Desktop.Services;
using LearnEnglish.Desktop.Theme;

namespace LearnEnglish.Desktop.Presentation
{
    public partial class BaseForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public ITheme Theme;

        public BaseForm()
        {
            InitializeComponent();
            p_navigate.MouseMove += MouseMoveEvent;
            p_navigate.MouseDown += MouseDownEvent;
            p_navigate.MouseUp += MouseUpEvent;

            lbl_title.MouseMove += MouseMoveEvent;
            lbl_title.MouseDown += MouseDownEvent;
            lbl_title.MouseUp += MouseUpEvent;
        }

        private static Color HexToColor(string hex) => (Color)new ColorConverter().ConvertFromString(hex);

        private void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }
        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            if (this is not FrmMain)
            {
                btn_theme.Visible = false;
                lbl_title.Text = $"Learn English - {Text}";
            }
            if (this is FrmInfo || this is FrmNewKey || this is FrmHotKey)
            {
                btn_info.Visible = false;
            }

            this.RoundBorder();
            Theme = LocalStorage.Instancia.LocalStorageInfo.IsDarkMode == true ? new DarkTheme() : new LightTheme();
            SetTheme();
        }

        protected virtual void SetTheme()
        {
            BackColor = HexToColor(Theme.BackGroundSecondary);
            ForeColor = HexToColor(Theme.ForeColorPrimary);
            p_navigate.BackColor = HexToColor(Theme.BackGroundPrimary);
            btn_theme.Image = LocalStorage.Instancia.LocalStorageInfo.IsDarkMode == true ? Resources.sun_icon : Resources.moon_icon;
            DefineThemeAllControls(this);
        }

        public void DefineThemeAllControls(Control rootControl)
        {
            foreach (Control control in rootControl.Controls)
            {
                if (control is Button || control is TextBox)
                {
                    control.BackColor = HexToColor(Theme.BackGroundInput);
                    control.ForeColor = HexToColor(Theme.ForeColorInput);
                }
                else if (control is Label)
                {
                    control.ForeColor = HexToColor(Theme.ForeColorPrimary);
                }
                else if (control is DataGridView dg)
                {
                    dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dg.ColumnHeadersDefaultCellStyle.BackColor = HexToColor(Theme.BackGroundPrimary);
                    dg.ColumnHeadersDefaultCellStyle.ForeColor = HexToColor(Theme.ForeColorPrimary);
                    dg.ColumnHeadersDefaultCellStyle.Font = new Font(dg.ColumnHeadersDefaultCellStyle.Font.FontFamily, 12);
                    dg.DefaultCellStyle.ForeColor = HexToColor(Theme.ForeColorInput);
                    dg.DefaultCellStyle.BackColor = HexToColor(Theme.BackGroundInput);
                    dg.BackgroundColor = HexToColor(Theme.BackGroundInput);
                }
                else if (control.Controls != null)
                {
                    foreach (Control child in control.Controls)
                    {
                        DefineThemeAllControls(child);
                    }
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();

        }

        private async void btn_theme_Click(object sender, EventArgs e)
        {
            await ChangeThemeAsync();
        }

        private async Task ChangeThemeAsync()
        {
            if (LocalStorage.Instancia.LocalStorageInfo.IsDarkMode == true)
            {
                LocalStorage.Instancia.LocalStorageInfo.IsDarkMode = false;
                Theme = new LightTheme();
            }
            else
            {
                LocalStorage.Instancia.LocalStorageInfo.IsDarkMode = true;
                Theme = new DarkTheme();
            }

            await LocalStorage.Instancia.SaveChangesAsync();
            SetTheme();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            new FrmInfo().ShowDialog();
        }

        private async void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (this is FrmNewKey)
            {
                return;
            }

            switch (GlobalHotKeyService.Instancia.HotKeyMatch(e.KeyCode))
            {
                case Models.HotKeyType.Close:
                    Close();
                    break;
                case HotKeyType.ChangeTheme:
                    if (this is FrmMain)
                    {
                        await ChangeThemeAsync();
                    }
                    break;
                default:
                    break;
            }
        }

        private void BaseForm_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0F;
        }

        private void BaseForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}
