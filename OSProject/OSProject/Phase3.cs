//Phase3: Deadlock Creation

using System;
using System.Threading;

public class CookieJarPhase3
{
    private object lock1 = new object();
    private object lock2 = new object();

    public void ThreadA()
    {
        lock (lock1)
        {
            Console.WriteLine("[Phase 3] [Thread A] Locked Resource 1");
            Thread.Sleep(100); // Simulate some work

            lock (lock2)
            {
                Console.WriteLine("[Phase 3] [Thread A] Locked Resource 2");
                //Continuing with the operation
            }
        }
    }

    public void ThreadB()
    {
        lock (lock1) // Ensuring lock order consistency
        {
            Console.WriteLine("[Phase 3] [Thread B] Locked Resource 1");
            Thread.Sleep(100); // Simulate some work

            lock (lock2)
            {
                Console.WriteLine("[Phase 3] [Thread B] Locked Resource 2");
                //Continuing with the operation
            }
        }
    }
}
