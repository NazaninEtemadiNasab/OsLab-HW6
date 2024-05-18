using System;
using System.Threading;

class AutoResetEvent1
{
    static AutoResetEvent autoResetEvent = new AutoResetEvent(true);

    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Thread thread = new Thread(function);
            thread.Start(i + 1);
        }
        Console.ReadKey();
    }

    static void function(object pno)
    {
        autoResetEvent.WaitOne();

        Console.WriteLine($"process {pno} ...");
        Thread.Sleep(2000);
        Console.WriteLine($"process {pno} ...");

        autoResetEvent.Set();
    }
}