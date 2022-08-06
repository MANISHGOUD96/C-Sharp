using System;
class demo
{
    void test()
    {
        Console.WriteLine("test: " + this);
    }
    static void Main()
    {
        demo d = new demo();
        d.test();
        Console.WriteLine("Main:" +d);
        Console.ReadLine();
    }
}
