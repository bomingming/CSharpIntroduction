/*using System;

namespace Problem.Chapter4
{
    internal class _4_17_PropertyWithManyFieldsApp
    {
        // 하나의 프로퍼티가 여러 필드를 사용하는 예
        private string text = "Dept. of Computer Engineering";
        private bool isModified = false;
        public string Text
        {
            get { return text; }
            set { text = value; isModified = true; } // 2개의 필드와 연관
        }
        public void PrintStatus()
        {
            Console.WriteLine("text is \"" + text + "\", and " + (isModified ? "is" : "not") + " modified.");
        }
        public static void Main()
        {
            _4_17_PropertyWithManyFieldsApp obj = new _4_17_PropertyWithManyFieldsApp();
            obj.PrintStatus(); // 초기 상태를 출력
            obj.Text = "Programming Language Lab"; // 프로퍼티의 set 동작. text의 값은 value로, isModified는 true로 변경
            obj.PrintStatus(); // 변경 상태를 출력
        }
    }
}
*/