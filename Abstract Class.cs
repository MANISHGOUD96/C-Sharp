
//.................Abstract Class............... 

using System;
abstract class Test
{
    public void Show()
    {
        Console.WriteLine("Hi");
    }
}

class Demo : Test
{ 
    static void Main()
    {
        Test t = new Demo();
        t.Show();
        Console.ReadKey();
    }
}