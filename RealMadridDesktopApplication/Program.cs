using RealMadridDesktopApplication.Forms;

namespace RealMadridDesktopApplication
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
            MainPage mainPage = new MainPage();
            //LoginPage loginPage = new LoginPage();
            Application.Run(mainPage);
        }
    }
}