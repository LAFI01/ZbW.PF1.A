using MB07.A12_1._2;
using MB07.A12_1._3;

namespace MB07
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

            Application.Run(new A12_1_2());
            //Application.Run(new A12_1_3());

        }
    }
}