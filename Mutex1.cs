using System;
using System.Threading;

class Mutex1
{
    static Mutex mutex = new Mutex();

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
        mutex.WaitOne();
        Console.WriteLine($"process {pno} ...");
        Thread.Sleep(2000);
        Console.WriteLine($"process {pno} ...");
        mutex.ReleaseMutex();
    }
}