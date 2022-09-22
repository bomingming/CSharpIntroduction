/*using System;

delegate void SampleDelegate(); // 델리게이트 정의

class DelegateClass
{
    public void DelegateMethod() // 델리게이트 할 메소드
    {
        Console.WriteLine("In the DelegateClass.DelegateMethod ...");
    }
}

class DelegateApp
{
    public static void Main()
    {
        DelegateClass obj = new DelegateClass(); // 델리게이트 객체 생성
        SampleDelegate sd = new SampleDelegate(obj.DelegateMethod); // 객체에 메소드 연결
        sd(); // 델리게이트 통해 메소드 호출
    }
}*/