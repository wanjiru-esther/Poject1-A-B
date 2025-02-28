//Phase 1: Basic Thread Operations

using System;
using System.Threading;

public class CookieJarPhase1
{
    private int cookies = 5; 
    private object lockObject = new object(); //for safety

    // Add a cookie to the jar
    public void AddCookie()
    {
        lock (lockObject)
        {
            cookies++;
            Console.WriteLine($"[Phase 1] A cookie was added! Cookies in jar: {cookies}");
        }
    }

    // Take a cookie from the jar
    public void TakeCookie()
    {
        lock (lockObject)
        {
            if (cookies > 0)
            {
                cookies--;
                Console.WriteLine($"[Phase 1] A cookie was taken! Cookies left: {cookies}");
            }
            else
            {
                Console.WriteLine("[Phase 1] No more cookies left in the jar!");
            }
        }
    }
}
