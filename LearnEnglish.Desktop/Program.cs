using LearnEnglish.Desktop.Factorys;
using LearnEnglish.Desktop.Interfaces;
using LearnEnglish.Desktop.Presentation;
using LearnEnglish.Desktop.Services;
using LearnEnglish.Desktop.Services.DefaultTheme;
using LearnEnglish.Desktop.Services.StartupApplication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Runtime.InteropServices;

namespace LearnEnglish.Desktop
{
    internal static class Program
    {
        public static bool LaunchedViaStartup { get; private set; }
        [STAThread]
        static async Task Main(string[] args)
        {
            Program.LaunchedViaStartup = args != null && args.Any(arg => arg.Equals("startup", StringComparison.CurrentCultureIgnoreCase));
            ApplicationConfiguration.Initialize();

            var builder = new HostBuilder()
                   .ConfigureServices((hostContext, services) =>
                   {
                       services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5189") });
                       services.AddScoped<FrmMain>();
                       services.AddScoped<IHttpService, HttpService>();
                       services.AddScoped<FrmCreateTextFactory>();

                       if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                       {
                           services.AddScoped<IStartupApplication, StartupApplicationWindows>();
                           services.AddScoped<IDefaultTheme, DefaultThemeWindows>();
                       }
                       else
                       {
                           throw new PlatformNotSupportedException();
                       }
                   });

            using var serviceScope = builder.Build().Services.CreateScope();
            serviceScope.ServiceProvider.GetRequiredService<IStartupApplication>().Registry();

            if (LocalStorage.Instancia.LocalStorageInfo.IsDarkMode == null)
            {
                LocalStorage.Instancia.LocalStorageInfo.IsDarkMode = serviceScope.ServiceProvider.GetRequiredService<IDefaultTheme>().IsDarkMode();
                await LocalStorage.Instancia.SaveChangesAsync();
            }

            Application.Run(serviceScope.ServiceProvider.GetRequiredService<FrmMain>());
        }
    }
}