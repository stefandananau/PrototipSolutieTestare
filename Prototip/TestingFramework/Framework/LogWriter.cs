namespace TestingFramework.Framework
{
    public static class LogWriter
    {
        private static NLog.Logger logger = null;

        public static NLog.Logger GetLogger()
        {
            if (logger == null)
            {
                logger = NLog.LogManager.GetLogger("MyLogger");
            }
            return logger;
        }
    }
}
