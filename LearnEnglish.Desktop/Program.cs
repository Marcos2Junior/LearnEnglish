using LearnEnglish.Desktop.Factorys;
using LearnEnglish.Desktop.Interfaces;
using LearnEnglish.Desktop.Presentation;
using LearnEnglish.Desktop.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LearnEnglish.Desktop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();


            var builder = new HostBuilder()
                   .ConfigureServices((hostContext, services) =>
                   {
                       services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5189") });
                       services.AddScoped<FrmMain>();
                       services.AddScoped<IHttpService, HttpService>();
                       services.AddScoped<FrmCreateTextFactory>();
                   });

            using var serviceScope = builder.Build().Services.CreateScope();
            Application.Run(serviceScope.ServiceProvider.GetRequiredService<FrmMain>());
        }
    }
}