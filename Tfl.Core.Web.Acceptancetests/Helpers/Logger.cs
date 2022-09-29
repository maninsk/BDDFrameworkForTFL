namespace Tfl.Core.Web.Acceptancetests.Helpers
{
    public class Logger
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Info(string message)
        {
            log.Info(message);
        }
    }
}
