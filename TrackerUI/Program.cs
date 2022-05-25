namespace TrackerUI
{
     static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializedConnections(true, true);
            Application.Run(new CreatePrizeForm());


            //Application.Run(new TournamentDashboardForm());
        }
    }
}