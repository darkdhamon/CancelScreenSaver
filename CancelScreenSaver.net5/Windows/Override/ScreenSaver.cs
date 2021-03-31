using CancelScreenSaver.net5.Windows.Threads;

namespace CancelScreenSaver.net5.Windows.Override
{
    public static class ScreenSaver
    {
        public static void DisableScreenSaver()
        {
            AppExecutionState.Set(ExecutionState.DisplayRequired | ExecutionState.SystemRequired |
                                  ExecutionState.Continuous);
        }
        
        public static void EnableScreenSaver()
        {
            AppExecutionState.Clear();
        }

        
    }
}
