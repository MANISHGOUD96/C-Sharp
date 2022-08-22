
//...........Method Hiding non static.......
//...............Using base Key.............

using System;
class Parent
{
    protected void Marry()
    {
        Console.WriteLine("Father Choice");
    }
}

class Child:Parent
{
    protected new void Marry()
    {
        base.Marry();
        Console.WriteLine("After three year");
    } 

    static void Main()
    {
        Child c = new Child();
        c.Marry();
        Console.ReadKey();
    }
}