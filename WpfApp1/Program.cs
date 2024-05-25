using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using WpfApp1.Contexts;
using WpfApp1.Services;
using WpfApp1.Views;

namespace WpfApp1;

public class Program
{
    [STAThread]
    public static void Main()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        var host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                if (!(Environment.GetCommandLineArgs().Length > 1))
                {
                    services.AddSingleton<App>();
                    services.AddSingleton<MainWindow>();
                    services.AddSingleton<AddIn>();
                }

                services.AddDbContext<ApplicationContext>(options => options.UseMySql(
                        connectionString,
                        ServerVersion.AutoDetect(connectionString)
                    )
                );
            })
            .Build();
        
        var a = new AddIn();

        var app = host.Services.GetService<App>();
        app?.Run();
    }
}