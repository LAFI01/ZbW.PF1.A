namespace MB06
{
    using MB06.A11_1._1;
    using MB06.A11_1._2;
    using MB06.A11_1._4;

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

            Application.Run(new A11_1_1());
            //Application.Run(new A11_1_2());
            //Application.Run(new A11_1_4());

        }
    }
}