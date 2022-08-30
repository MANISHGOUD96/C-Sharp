using System;
abstract class Test
{
    public abstract void M1();
    public abstract void M2();
}

abstract class Demo : Test
{
    public override void M1()
    {
        Console.WriteLine("Hi");
    }
}

class Process : Demo
{
    public override void M2()
    {
        Console.WriteLine("Hello");
    }

    static void Main()
    {
        Demo p = new Process();
        p.M1();
        p.M2();
    }
}