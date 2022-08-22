//...............Method Overriding.................
//.............Using inernal Keyword...............


using System;
class Grand
{
    internal void Property()
    {
        Console.WriteLine("Grand Choice");
    }
}

class Parent:Grand  
{ 
    internal virtual void Marry()
    { 
        Console.WriteLine("Father Choice");
    }
}

class Child : Parent
{
    internal override void Marry()
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