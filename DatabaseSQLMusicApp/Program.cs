namespace DatabaseSQLMusicApp
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
            Application.Run(new Form1());
            using (var context = new AppDbContext())
            {
                // Create database and table if they don't exist
                context.InitializeDatabase();


                AlbumsDAO_Framework a = new AlbumsDAO_Framework();
                a.Create3Mocks();
            }

        }
    }
}