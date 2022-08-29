
//....................Abstract Class (Overriding)...........................

using System;
abstract class Test
{
    public abstract void Show();
}

class Demo : Test
{
    public override void Show()
    {
        Console.WriteLine("Hello");
    }
    static void Main()
    {
        Test t = new Demo();
        t.Show();
        Console.ReadKey();
    }
}