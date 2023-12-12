using Castle.Core.Internal;
using System.Diagnostics;
using System.Linq;
using System;
namespace TestingFramework.Framework.Helpers
{
    public static class ProcessHelper
    {
        public static void KillAll(string processName)
        {
            LogWriter.GetLogger().Debug("Killing processes {processName}", processName);
            try
            {
                Process.GetProcesses().Where(process => process.ProcessName == processName).ForEach(process => process.Kill());
            }
            catch(Exception ex)
            {
                LogWriter.GetLogger().Error("Exception encountered :{exception}", ex.Message);
            }
            
        }
    }
}
