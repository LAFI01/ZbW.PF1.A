using MB01.A1_2;
using MB01.A1_2;
using MB01.A1_2;
using MB01.A1_2;
using MB01.A1_2;
using MB01.A2_1;
using MB01.A2_1;
using MB01.A4_2;
using MB01.A4_2;
using MB01.A4_2;
using MB01.A4_2;
using MB01.A5_1;
using MB01.A5_1;
using MB01.A5_1;
using MB01.A6_2;
using MB01.A6_2;
using MB01.A6_2;

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
            
            //A1-2
            //Application.Run(new A1_2_1());
            //Application.Run(new A1_2_2());
            //Application.Run(new A1_2_3());
            //Application.Run(new A1_2_4());
            //Application.Run(new A1_2_5());

            //A2-1
            //Application.Run(new A2_1_1());
            //Application.Run(new A2_1_2());
            //Application.Run(new A2_1_3());

            //A4-2
            Application.Run(new A4_2_1());
            //Application.Run(new A4_2_2());
            //Application.Run(new A4_2_3());
            //Application.Run(new A4_2_4());

            //A5-1
            //Application.Run(new A5_1_1());
            //Application.Run(new A5_1_2());
            //Application.Run(new A5_1_3());

            //A6-2
            //Application.Run(new A6_2_1());
            //Application.Run(new A6_2_2());
            //Application.Run(new A6_2_3());
            //Application.Run(new A6_2_4());

        }
    }
}