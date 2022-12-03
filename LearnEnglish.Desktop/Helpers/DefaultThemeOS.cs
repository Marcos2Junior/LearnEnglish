using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace LearnEnglish.Desktop.Helpers
{
    public static class DefaultThemeOS
    {
        public static bool IsDarkMode()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return IsDarkModeWindows();
            }

            return false;
        }


        private static bool IsDarkModeWindows()
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
