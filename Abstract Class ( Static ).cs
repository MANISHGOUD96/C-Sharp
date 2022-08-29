
//....................Abstract Class (Static).........................

using System;
abstract class Test
{
   public Test()
    {
        Console.WriteLine("Hello");
    }
}

class Demo : Test
{
    static void Main()
    {
        Test d = new Demo();
        Console.ReadKey();
    }
}