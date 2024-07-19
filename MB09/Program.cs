using MB09.A13_1._1;
using MB09.A13_1._2;
using MB09.A13_2._1;
using MB09.A13_2._2.View;

namespace MB09
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
            Application.Run(new A13_1_1());
            //Application.Run(new A13_1_2());

            //Application.Run(new A13_2_1());
            //Application.Run(new A13_2_2());

        }
    }
}