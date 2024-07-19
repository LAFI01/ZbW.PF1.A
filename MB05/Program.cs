using MB05.A10_1;
using MB05.A9_2;

namespace MB05
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

            //A9_2
            Application.Run(new A9_2_1());
            //Application.Run(new A9_2_2());
            //Application.Run(new A9_2_3());
            //Application.Run(new A9_2_4());
            //Application.Run(new A9_2_5());
            //Application.Run(new A9_2_6());

            //A10_1
            //Application.Run(new A10_1_1());
            //Application.Run(new A10_1_2());
            //Application.Run(new A10_1_3());
            //Application.Run(new A10_1_5());
            //Application.Run(new A10_1_6());
            //Application.Run(new A10_1_7());


        }
    }
}