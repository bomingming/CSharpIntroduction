/*using System;

class EventApp
{
    public EventHandler MyEvent; // 이벤트 선언
    // EventHandler : (대리자) 이벤트 데이터가 없는 이벤트를 처리할 메소드 나타냄
    void MyEventHandler(object sender, EventArgs e) // 이벤트 처리기 작성
    {
        Console.WriteLine("Hello World");
    }
    public EventApp() // 생성자
    {
        this.MyEvent += new EventHandler(MyEventHandler); // 이벤트 처리기 등록
    }
    public void InvokeEvent()
    {
        if (MyEvent != null)
            MyEvent(this, null); // 이벤트 발생
    }
    public static void Main()
    {
        new EventApp().InvokeEvent();
    }
}*/