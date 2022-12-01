using LearnEnglish.Desktop.Extensions;
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

        public BaseForm()
        {
            InitializeComponent();
            p_navigate.MouseMove += MouseMoveEvent;
            p_navigate.MouseDown += MouseDownEvent;
            p_navigate.MouseUp += MouseUpEvent;
        }

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
        }
    }
}
