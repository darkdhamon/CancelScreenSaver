using System;
using CancelScreenSaver.net5.Windows.Override;

namespace CancelScreenSaver.net5
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenSaver.DisableScreenSaver();
            Console.WriteLine("Screen Saver Disabled!");
            Console.WriteLine("Press Any Key to Reenable.");
            Console.ReadKey();
            ScreenSaver.EnableScreenSaver();
            Console.WriteLine("Screen Saver Enabled.");
        }
        
    }
}
