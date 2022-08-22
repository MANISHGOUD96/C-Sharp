
//...........Method Hiding static..........
//...........Using class name Key..........

using System;
class Parent
{
    protected static void Marry()
    {
        Console.WriteLine("Father Choice");
    }
}

class Child : Parent
{
    protected static new void Marry()
    {
        Parent.Marry();
        Console.WriteLine("After three year");
    } 
    static void Main()
    {
        Marry();
        Console.ReadKey();
    }
}