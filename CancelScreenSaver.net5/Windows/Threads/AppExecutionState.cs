using System.Runtime.InteropServices;

namespace CancelScreenSaver.net5.Windows.Threads
{
    public static class AppExecutionState
    {
        
        public static void Set(ExecutionState esFlags)
        {
            SetThreadExecutionState(esFlags);
        }

        public static void Clear()
        {
            Set(ExecutionState.Continuous);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="esFlags"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);
    }
}