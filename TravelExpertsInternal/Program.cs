namespace TravelExpertsInternal
{
    /*
 * Travel Experts Application Workshop 1
 * 
 * Author: Allen Horton, Hector Munoz-Villouta, Peter Spangler, Peter Thiel
 * 
 * 
 * Date: May 2023
 */
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
            Application.Run(new Start());
        }
    }
}