//Phase2: Resource Protection

using System;
using System.Threading;

public class CookieJarPhase2
{
    private int cookies; 
    private static readonly Mutex mutex = new Mutex(); // Mutex for thread safety

    //initializes cookies to 5
    public CookieJarPhase2()
    {
        cookies = 5;
    }

    // Add a cookie to the jar
    public void AddCookie()
    {
        mutex.WaitOne(); // Lock the resource
        try
        {
            cookies++;
            Console.WriteLine($"[Phase 2] A cookie was added! Cookies in jar: {cookies}");
        }
        finally
        {
            mutex.ReleaseMutex(); // Unlock the resource
        }
    }

    // Take a cookie from the jar
    public void TakeCookie()
    {
        mutex.WaitOne(); // Lock the resource
        try
        {
            if (cookies > 0)
            {
                cookies--;
                Console.WriteLine($"[Phase 2] A cookie was taken! Cookies left: {cookies}");
            }
            else
            {
                Console.WriteLine("[Phase 2] No more cookies left in the jar!");
            }
        }
        finally
        {
            mutex.ReleaseMutex(); // Unlock the resource
        }
    }
}
