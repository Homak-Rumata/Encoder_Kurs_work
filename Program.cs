
namespace Тестовое_окно
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MainForm GeneralMainForm = new MainForm();
            Application.Run(new LoginForm(GeneralMainForm));
            Console.WriteLine("f");
        }


    }
}