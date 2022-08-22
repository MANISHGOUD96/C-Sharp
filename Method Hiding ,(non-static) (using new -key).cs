
//...............Method Hiding.................
//.........non-static(Using new-key)...........

using System;
class Parent
{
    protected void Property()
    {
        Console.WriteLine("cash | gold | land | Car");
    }
    protected void Marry()
    {
        Console.WriteLine("Father Choice");
    }
}

class Child : Parent
{
    protected new void Marry()
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