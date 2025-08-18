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
            // agora se a conectionString estiver errada, o programa vai dar um aviso
            try
            {
                Start();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro com o banco de dados:");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro na aplica��o:");
            }
        }

        static void Start() 
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

            //deixar assim e coloque o arquivo mdf dentro da pasta que tem o programa com o nome ProjetoIntegrador.mdf
            return @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Path.Combine(AppContext.BaseDirectory, "ProjetoIntegrador.mdf")};Integrated Security=True;Connect Timeout=30";
        }

    }
}