
//...............Method Overriding.................

using System;
class Parent
{
    protected void Property()
    {
        Console.WriteLine("cash | gold | land | Car");
    }
    protected virtual void Marry()
    {
        Console.WriteLine("Father Choice");
    }
}

class Child : Parent
{
    protected override void Marry()
    {
        Console.WriteLine("Child Choice");
    }
    static void Main()
    {
        Child c = new Child();
        c.Marry();
        Console.ReadKey();
    }
}