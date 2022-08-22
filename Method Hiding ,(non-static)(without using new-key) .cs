
//...............Method Hiding.................
//.......non-static(without using new-key).....

using System;
class Grand
{
    protected  void Property()
    {
        Console.WriteLine("Grand Choice");
    }
}

class Parent:Grand  
{ 
    protected  void Marry()
    { 
        Console.WriteLine("Father Choice");
    }
}

class Child : Parent
{
    protected  void Marry()
    {
   
        Console.WriteLine("Child Choice");
    }
    static void Main()
    { 
        Marry();
        Console.ReadKey();
    }
}