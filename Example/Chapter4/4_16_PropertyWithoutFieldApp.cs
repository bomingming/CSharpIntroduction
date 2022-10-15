/*using System;

namespace Problem.Chapter4
{
    internal class _4_16_PropertyWithoutFieldApp
    {
        // 필드와 짝을 이루지 않는 프로퍼티
        public string Message // 대응하는 필드가 없는 프로퍼티
        {
            get { return Console.ReadLine(); }
            set { Console.WriteLine(value); }
        }
        public static void Main()
        {
            _4_16_PropertyWithoutFieldApp obj = new _4_16_PropertyWithoutFieldApp();
            obj.Message = obj.Message;
            // 모니터에 value 출력 / 콘솔에서 value 입력
        }
    }
}
*/