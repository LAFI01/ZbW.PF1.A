using MB08.A12_1._4.View;
using MB08.A12_1._5.View;
using MB08.A12_1._6;

namespace MB08
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

            Application.Run(new A12_1_4());

            //Application.Run(new A12_1_5());
            //Application.Run(new A12_1_6());
        }
    }
}