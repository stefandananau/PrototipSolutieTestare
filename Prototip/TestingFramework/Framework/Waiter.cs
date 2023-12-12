using System;
using System.Diagnostics;
using System.Threading;

namespace TestingFramework.Framework
{
    public static class Waiter
    {
        public static bool WaitUntil(Func<bool> condition, int timeoutMiliseconds)
        {
            TimeSpan timeSpan = TimeSpan.FromMilliseconds(timeoutMiliseconds);
            Stopwatch stopwatch = new Stopwatch();
            while (!condition())
            {
                if(stopwatch.Elapsed > timeSpan)
                {
                    LogWriter.GetLogger().Debug("Condition took too long to complete");
                    return false;
                }
            }
            LogWriter.GetLogger().Info("Condition complete after {miliseconds} miliseconds", stopwatch.Elapsed);
            return true;
        }

        public static void Wait(int timeoutMiliseconds)
        {
            Thread.Sleep(timeoutMiliseconds);
        }
    }
}
