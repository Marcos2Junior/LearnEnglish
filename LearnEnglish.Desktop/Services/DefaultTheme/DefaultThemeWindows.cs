using LearnEnglish.Desktop.Interfaces;
using Microsoft.Win32;

namespace LearnEnglish.Desktop.Services.DefaultTheme
{
    public class DefaultThemeWindows : IDefaultTheme
    {
        public bool IsDarkMode()
        {
            try
            {
                int res = (int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1);
                return res == 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
