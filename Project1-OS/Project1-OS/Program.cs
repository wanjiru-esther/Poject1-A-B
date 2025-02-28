using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n-----Running Phase 1: Basic Thread Operations-----");
        CookieJarPhase1 phase1Jar = new CookieJarPhase1();
        Thread phase1Take1 = new Thread(() => phase1Jar.TakeCookie());
        Thread phase1Take2 = new Thread(() => phase1Jar.TakeCookie());
        Thread phase1Add = new Thread(() => phase1Jar.AddCookie());
        phase1Take1.Start();
        phase1Take2.Start();
        phase1Add.Start();
        phase1Take1.Join();
        phase1Take2.Join();
        phase1Add.Join();
        Console.WriteLine("Phase 1 completed.\n");

        Thread.Sleep(500);  

        Console.WriteLine("\n-----Running Phase 2: Resource Protection-----");
        CookieJarPhase2 phase2Jar = new CookieJarPhase2();
        Thread phase2Take1 = new Thread(() => phase2Jar.TakeCookie());
        Thread phase2Take2 = new Thread(() => phase2Jar.TakeCookie());
        Thread phase2Add = new Thread(() => phase2Jar.AddCookie());
        phase2Take1.Start();
        phase2Take2.Start();
        phase2Add.Start();
        phase2Take1.Join();
        phase2Take2.Join();
        phase2Add.Join();
        Console.WriteLine("Phase 2 completed.\n");

        Thread.Sleep(500); 

        Console.WriteLine("\n-----Running Phase 3: Deadlock Creation -----");
        CookieJarPhase3 phase3Jar = new CookieJarPhase3();
        Thread threadA3 = new Thread(() => phase3Jar.ThreadA());
        Thread threadB3 = new Thread(() => phase3Jar.ThreadB());
        threadA3.Start();
        threadB3.Start();
        threadA3.Join();
        threadB3.Join();
        Console.WriteLine("Phase 3 completed.\n");

        Thread.Sleep(500);  

        // Phase 4 
        Console.WriteLine("\n-----Running Phase 4: Deadlock Resolution-----");
        CookieJarPhase4 phase4Jar = new CookieJarPhase4();

        Thread threadA4 = new Thread(() => phase4Jar.ThreadA());
        Thread threadB4 = new Thread(() => phase4Jar.ThreadB());
        Thread threadC4 = new Thread(() => phase4Jar.ThreadA()); // Third thread
        Thread threadD4 = new Thread(() => phase4Jar.ThreadB()); // Fourth thread

        threadA4.Start();
        threadB4.Start();
        threadC4.Start();
        threadD4.Start();

        threadA4.Join();
        threadB4.Join();
        threadC4.Join();
        threadD4.Join();

        Console.WriteLine("\nPhase 4 completed!\n");

        Console.WriteLine("All Four phases have finished!");
    }
}
/**Project All 4 Phases output:
*
*
*----Running Phase 1: Basic Thread Operations-----
[Phase 1] A cookie was taken! Cookies left: 4
[Phase 1] A cookie was added! Cookies in jar: 5
[Phase 1] A cookie was taken! Cookies left: 4
Phase 1 completed.


-----Running Phase 2: Resource Protection-----
[Phase 2] A cookie was taken! Cookies left: 4
[Phase 2] A cookie was taken! Cookies left: 3
[Phase 2] A cookie was added! Cookies in jar: 4
Phase 2 completed.


-----Running Phase 3: Deadlock Creation -----
[Phase 3] [Thread A] Locked Resource 1
[Phase 3] [Thread A] Locked Resource 2
[Phase 3] [Thread B] Locked Resource 1
[Phase 3] [Thread B] Locked Resource 2
Phase 3 completed.


-----Running Phase 4: Deadlock Resolution-----
[Phase 4] [Thread A] Locked Resource 1!
[Phase 4] [Thread A] Took a cookie from both jars!
[Phase 4] [Thread B] Locked Resource 1!
[Phase 4] [Thread B] Took a cookie from both jars!
[Phase 4] [Thread A] Locked Resource 1!
[Phase 4] [Thread A] Took a cookie from both jars!
[Phase 4] [Thread B] Locked Resource 1!
[Phase 4] [Thread B] Took a cookie from both jars!

Phase 4 completed!

All Four phases have finished!
*
*
****/