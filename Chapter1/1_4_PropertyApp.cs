/*using System;

class PropertyClass
{
    private int privateValue; //필드명
    public int PrivateValue     //프로퍼티명
    {
        get { return privateValue; } // 값을 참조하는 get-accessor
        set { privateValue = value; } // 값을 지정하는 set-accessor
        // value는 예약어
    }
    public void PrintValue()
    {
        Console.WriteLine("Hidden Value = " + privateValue);
    }
}

class PropertyApp
{
    public static void Main()
    {
        int n;
        PropertyClass obj = new PropertyClass();
        obj.PrivateValue = 100;
        obj.PrintValue();
        n = obj.PrivateValue;
        Console.WriteLine("     Value = " + n);
    }
}*/