using System;
using System.Threading;

public class CookieJarPhase1
{
    private int cookies = 11;  // Initialize with 11 cookies
    private object lockObject = new object();  // For thread safety

    // Add a cookie to the jar
    public void AddCookie()
    {
        lock (lockObject)  // Ensure that only one thread can access this block at a time
        {
            cookies++;
            Console.WriteLine($"[Phase 1] A cookie was added! Cookies in jar: {cookies}");
        }
    }

    // Take a cookie from the jar
    public void TakeCookie()
    {
        lock (lockObject)  // Ensure that only one thread can access this block at a time
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
}   }