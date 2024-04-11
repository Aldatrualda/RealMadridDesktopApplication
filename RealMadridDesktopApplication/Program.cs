using RealMadridDesktopApplication.Forms;
using NLog;

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
            Logger logger = LogManager.GetCurrentClassLogger();

            logger.Info("Program launched");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            LoginPage loginPage = new LoginPage();  
            //MainPage mainPage = new MainPage();
            Application.Run(loginPage);
            logger.Info("Program closed");
        }

    }
}