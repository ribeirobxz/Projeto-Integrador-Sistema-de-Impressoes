using WinFormsApp1.Service;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            MockService service = new MockService();

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain(service));
        }
    }
}