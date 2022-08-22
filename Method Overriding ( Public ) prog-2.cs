
//...............Method Overriding.................
//.............Using public Keyword................

using System;
class Grand
{
    public void Property()
    {
        Console.WriteLine("Grand Choice");
    }
}

class Parent:Grand  
{ 
    public virtual void Marry()
    { 
        Console.WriteLine("Father Choice");
    }
}

class Child : Parent
{
    public override void Marry()
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