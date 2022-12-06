using LearnEnglish.Desktop.Interfaces;

namespace LearnEnglish.Desktop.Services.StartupApplication
{
    public class StartupApplicationWindows : IStartupApplication
    {
        public void Registry()
        {
            Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", IStartupApplication.NameApplication, System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
        }
    }
}
