using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinFormsApp1.Context;
using WinFormsApp1.Service;

namespace WinFormsApp1
{
    internal static class Program
    {

        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<FormMain>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    services.AddTransient<AlunoService>();
                    services.AddDbContext<AppDatabaseContext>(options =>
                    {
                        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MinhaAppDb;Trusted_Connection=True;");
                    }, ServiceLifetime.Transient);

                    services.AddTransient<FormMain>();
                });
        }
    }
}