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
            // Initialize application settings
            ApplicationConfiguration.Initialize();

            // Run the database operations on a background thread
            Task.Run(() =>
            {
                using (var context = new AppDbContext())
                {
                    Console.WriteLine("Initializing Database...");
                    context.InitializeDatabase();  // Initialize the database

                    AlbumsDAO_Framework a = new AlbumsDAO_Framework();
                    a.Create3Mocks();  // Create mock data
                }
            });

            // Start the application form
            Application.Run(new Form1());
        }
    }
}
