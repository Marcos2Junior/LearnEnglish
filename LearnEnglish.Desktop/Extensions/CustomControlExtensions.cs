using System.Drawing.Drawing2D;

namespace LearnEnglish.Desktop.Extensions
{
    public static class CustomControlExtensions
    {
        public static void RoundBorder(this Control control)
        {
            using GraphicsPath graphicsPath = new();
            graphicsPath.AddRectangle(new Rectangle(1, 1, control.Width, control.Height));
            graphicsPath.AddRectangle(new Rectangle(1, 1, 10, 10));
            graphicsPath.AddPie(1, 1, 20, 20, 180, 90);
            graphicsPath.AddRectangle(new Rectangle(control.Width - 12, 1, 12, 13));
            graphicsPath.AddPie(control.Width - 24, 1, 24, 26, 270, 90);
            graphicsPath.AddRectangle(new Rectangle(1, control.Height - 10, 10, 10));
            graphicsPath.AddPie(1, control.Height - 20, 20, 20, 90, 90);
            graphicsPath.AddRectangle(new Rectangle(control.Width - 12, control.Height - 13, 13, 13));
            graphicsPath.AddPie(control.Width - 24, control.Height - 26, 24, 26, 0, 90);
            graphicsPath.SetMarkers();
            control.Region = new Region(graphicsPath);
        }
    }
}
