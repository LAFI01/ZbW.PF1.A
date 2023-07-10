using Aufgabe_A1_2_1;
using Aufgabe_A1_2_2;
using Aufgabe_A1_2_3;
using Aufgabe_A1_2_4;
using Aufgabe_A1_2_5;

namespace MB01
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
            Application.Run(new A1_2_1());
            //Application.Run(new A1_2_2());
            //Application.Run(new A1_2_3());
            //Application.Run(new A1_2_4());
            //Application.Run(new A1_2_5());
        }
    }
}