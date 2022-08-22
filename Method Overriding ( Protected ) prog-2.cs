
//...............Method Overriding.................
//............Using protected Keyword..............

using System;
class Grand
{
    protected void Property()
    {
        Console.WriteLine("Grand Choice");
    }
}

class Parent:Grand  
{ 
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