namespace MB02
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

            //A3-1
            Application.Run(new A3_1_1());
            //Application.Run(new A3_1_2());
            //Application.Run(new A3_1_6());

            //A4-2
            //Application.Run(new A4_2_1());
            //Application.Run(new A4_2_2());
            //Application.Run(new A4_2_3());
            //Application.Run(new A4_2_4());

            //A5-1
            //Application.Run(new A5_1_1());
            //Application.Run(new A5_1_2());
            //Application.Run(new A5_1_3());
        }
    }
}