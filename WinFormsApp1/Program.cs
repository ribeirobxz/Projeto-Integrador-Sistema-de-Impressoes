using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinFormsApp1.Context;

namespace WinFormsApp1
{
    internal static class Program
    {

        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            string connectionString = GetConnectionString();

            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder(connectionString).Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<FormMain>());
        }

        static IHostBuilder CreateHostBuilder(string connectionString)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<RepositoryContext>(new RepositoryContext(connectionString));

                    services.AddTransient<FormMain>();
                });
        }

        static string GetConnectionString() 
        {
            string filePath = Path.Combine(AppContext.BaseDirectory, "ConnectionString.txt");
            if (File.Exists(filePath))
            {
                try
                {
                    return File.ReadAllText(filePath);
                }
                catch (Exception)
                {
                }
            }
            return """Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ribei\OneDrive\Desktop\db\ProjetoIntegrador.mdf;Integrated Security=True;Connect Timeout=30""";
        }

    }
}