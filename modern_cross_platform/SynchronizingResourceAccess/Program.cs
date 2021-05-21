using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace SynchronizingResourceAccess
{
    class Program
    {
        static Random r = new Random();
        static string Message; // a shared resource
        static object conch = new object();

        static void Main(string[] args)
        {
            WriteLine("Please wait for the tasks to complete.");
            Stopwatch watch = Stopwatch.StartNew();

            //AccessConcurrent();
            //AccessWithLock();
            AccessWithMonitor();

            WriteLine();
            WriteLine($"Results: {Message}.");
            WriteLine($"{watch.ElapsedMilliseconds:#,##0} elapsed milliseconds.");
        }

        static void AccessConcurrent() // Results: BAAABABBBA.
        {
            Task a = Task.Factory.StartNew(MethodA);
            Task b = Task.Factory.StartNew(MethodB);
            Task.WaitAll(new Task[] { a, b });
        }

        static void AccessWithLock() // Results: AAAAABBBBB.
        {
            Task a = Task.Factory.StartNew(MethodAWithLock);
            Task b = Task.Factory.StartNew(MethodBWithLock);
            Task.WaitAll(new Task[] { a, b });
        }

        static void AccessWithMonitor() // Results: BBBBBAAAAA.
        {
            Task a = Task.Factory.StartNew(MethodAWithMonitor);
            Task b = Task.Factory.StartNew(MethodBWithMonitor);
            Task.WaitAll(new Task[] { a, b });
        }

        static void MethodA()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(r.Next(2000));
                Message += "A";
                Write(".");
            }
        }
        static void MethodB()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(r.Next(2000));
                Message += "B";
                Write(".");
            }
        }

        static void MethodAWithLock()
        {
            lock (conch)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(r.Next(2000));
                    Message += "A";
                    Write(".");
                }
            }

        }
        static void MethodBWithLock()
        {
            lock (conch)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(r.Next(2000));
                    Message += "B";
                    Write(".");
                }
            }

        }


        // A proven way to prevent deadlocks is to specify a timeout when attempting to get a lock
        // To do this, you must manually use the Monitor class instead of using the lock statement.

        static void MethodAWithMonitor()
        {
            try
            {
                if (Monitor.TryEnter(conch, TimeSpan.FromSeconds(15)))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(r.Next(2000));
                        Message += "A";
                        Write(".");
                    }
                }
                else
                {
                    WriteLine("Method A failed to enter a monitor lock.");
                }
            }
            finally
            {
                Monitor.Exit(conch);
            }
        }

        static void MethodBWithMonitor()
        {
            try
            {
                if (Monitor.TryEnter(conch, TimeSpan.FromSeconds(15)))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(r.Next(2000));
                        Message += "B";
                        Write(".");
                    }
                }
                else
                {
                    WriteLine("Method B failed to enter a monitor lock.");
                }
            }
            finally
            {
                Monitor.Exit(conch);
            }
        }

    }
}
