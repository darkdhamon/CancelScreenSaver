using System;
using System.Threading;
using System.Windows.Input;
namespace CancelScreenSaverCSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Thread.Sleep(300000);
            SendKeys.SendWait()
        }
    }
}
