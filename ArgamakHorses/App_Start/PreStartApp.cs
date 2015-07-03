namespace ArgamakHorses.App_Start
{
    public static class PreStartApp
    {
        private static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static void Start()
        {
            Logger.Info("Pre-Start Application");
        }
    }
}