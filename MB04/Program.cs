using MB04.A12_1._1;
using MB04.A12_1._3;

namespace MB04
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

            Application.Run(new A12_1_1());
            //Application.Run(new A12_1_3());

        }
    }
}