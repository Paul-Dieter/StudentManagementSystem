namespace Prg282Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.Run(new AdminLoginForm());
            ApplicationConfiguration.Initialize();
           
            
        }
    }
}