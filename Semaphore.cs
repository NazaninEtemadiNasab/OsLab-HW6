using System;
using System.Threading;

class Semaphore
{
    static System.Threading.Semaphore semaphore = new System.Threading.Semaphore(2, 2); // ظرفیت Semaphore: 2

    static void Main(string[] args)
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
        semaphore.WaitOne();
        Console.WriteLine($"process {pno} ...");
        Thread.Sleep(2000);
        Console.WriteLine($"process {pno} ...");
        semaphore.Release();
    }
}





