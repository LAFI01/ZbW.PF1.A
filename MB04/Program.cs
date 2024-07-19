using MB04.A9_2;

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

            //A9_2
            Application.Run(new A9_2_1());
            //Application.Run(new A9_2_2());
            //Application.Run(new A9_2_3());
            //Application.Run(new A9_2_4());
            //Application.Run(new A9_2_5());
            //Application.Run(new A9_2_6());

        }
    }
}