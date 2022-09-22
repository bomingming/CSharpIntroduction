/*using System;
using System.Threading; // 반드시 포함되어야 함

class ThreadApp
{
    static void ThreadBody() // 스레드 몸체 / 스레드를 위한 namespace
    {
        Console.WriteLine("In the thread body ..."); // 메소드 작성
    }
    public static void Main()
    {
        ThreadStart ts = new ThreadStart(ThreadBody); // 메소드를 델리게이트 연결
        Thread t = new Thread(ts); // 스레드 객체 생성
        Console.WriteLine("*** Start of Main");
        t.Start(); // 스레드 실행
        Console.WriteLine("*** End of Main");
    }
}*/