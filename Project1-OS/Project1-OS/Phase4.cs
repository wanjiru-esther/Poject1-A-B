//Thread4 Deadlock Resolution

using System;
using System.Threading;

public class CookieJarPhase4
{
    private object lock1 = new object();
    private object lock2 = new object();

    public void ThreadA()
    {
        bool lock1Acquired = false;
        bool lock2Acquired = false;

        lock1Acquired = Monitor.TryEnter(lock1, 500); // 500ms timeout for lock1
        if (lock1Acquired)
        {
            Console.WriteLine("[Phase 4] [Thread A] Locked Resource 1!");
            Thread.Sleep(100);

            lock2Acquired = Monitor.TryEnter(lock2, 500); // 500ms timeout for lock2
            if (lock2Acquired)
            {
                Console.WriteLine("[Phase 4] [Thread A] Took a cookie from both jars!");
            }
            else
            {
                Console.WriteLine("[Phase 4] [Thread A] Could not acquire Resource 2, retrying...");
            }
        }
        else
        {
            Console.WriteLine("[Phase 4] [Thread A] Could not acquire Resource 1, retrying...");
        }

        if (lock1Acquired) Monitor.Exit(lock1);
        if (lock2Acquired) Monitor.Exit(lock2);

        Thread.Sleep(200);  // Wait before retrying
    }

    public void ThreadB()
    {
        bool lock1Acquired = false;
        bool lock2Acquired = false;

        lock1Acquired = Monitor.TryEnter(lock1, 500); //Timeout for lock1 = 500ms 
        if (lock1Acquired)
        {
            Console.WriteLine("[Phase 4] [Thread B] Locked Resource 1!");
            Thread.Sleep(100);

            lock2Acquired = Monitor.TryEnter(lock2, 500); //Timeout for lock2 = 500ms 
            if (lock2Acquired)
            {
                Console.WriteLine("[Phase 4] [Thread B] Took a cookie from both jars!");
            }
            else
            {
                Console.WriteLine("[Phase 4] [Thread B] Could not acquire Resource 2, retrying...");
            }
        }
        else
        {
            Console.WriteLine("[Phase 4] [Thread B] Could not acquire Resource 1, retrying...");
        }

        if (lock1Acquired) Monitor.Exit(lock1);
        if (lock2Acquired) Monitor.Exit(lock2);

        Thread.Sleep(200);  // Wait before retrying
    }
}
