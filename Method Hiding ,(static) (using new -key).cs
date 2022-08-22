
//...............Method Hiding.................
//...........static (using new-key)............

using System;
class Grand
{
    public static void Property()
    {
        Console.WriteLine("Grand Choice");
    }
}
class Parent:Grand  
{ 
    public static void Marry()
    { 
        Console.WriteLine("Father Choice");
    }
}

class Child : Parent
{
    public static new void Marry()
    {
   

        Console.WriteLine("Child Choice");
    }
    static void Main()
    { 
        Marry();
        Console.ReadKey();
    }
}