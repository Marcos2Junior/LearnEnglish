using LearnEnglish.Desktop.Extensions;
using LearnEnglish.Desktop.Theme;
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
    public partial class BaseForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ITheme Theme = new DarkTheme();
        public BaseForm()
        {
            InitializeComponent();
            p_navigate.MouseMove += MouseMoveEvent;
            p_navigate.MouseDown += MouseDownEvent;
            p_navigate.MouseUp += MouseUpEvent;
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
            this.RoundBorder();
            SetTheme();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_theme_Click(object sender, EventArgs e)
        {
            Theme = Theme.GetType().Equals(typeof(DarkTheme)) ? new LightTheme() : new DarkTheme();
            SetTheme();
        }
        protected virtual void SetTheme()
        {
            BackColor = HexToColor(Theme.BackGroundSecondary);
            ForeColor = HexToColor(Theme.ForeColorPrimary);
            p_navigate.BackColor = HexToColor(Theme.BackGroundPrimary);
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
                else if (control.Controls != null)
                {
                    foreach (Control child in control.Controls)
                    {
                        DefineThemeAllControls(child);
                    }
                }
            }
        }
    }
}
