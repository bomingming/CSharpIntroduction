/*using System;

namespace Problem.Chapter4
{
    delegate void MultiCastDelegate();
    class Schedule
    {
        public void Now() // instance 메소드 -> 객체 생성 필요
        {
            Console.WriteLine("Time : " + DateTime.Now.ToString());
        }
        public static void Today() // static 메소드 -> 객체 생성 불필요
        {
            Console.WriteLine("Date : "+DateTime.Today.ToString());
        }
    }
    internal class _4_21_MultiCastApp
    {
        public static void Main()
        {
            Schedule obj = new Schedule();
            MultiCastDelegate mcd = new MultiCastDelegate(obj.Now);
            mcd += new MultiCastDelegate(Schedule.Today); // 외부 클래스의 static 메소드 -> 클래스명.메소드이름
            mcd(); // delegate 객체 호출 : 2개의 메소드를 수행
        }
    }
}
*/