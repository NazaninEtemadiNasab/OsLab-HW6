using System;
using System.Threading;

class Manitor1
{
    static object Object1 = new object();

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
        Monitor.Enter(Object1);
        Console.WriteLine($"process {pno} ...");
        Thread.Sleep(2000);
        Console.WriteLine($"process {pno} ...");
        Monitor.Exit(Object1);
    }
}