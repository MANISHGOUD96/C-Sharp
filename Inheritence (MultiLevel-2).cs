
//...................Herarchical Inheritence..............
using System;
class Parent
{
    protected void display()
    {
        Console.WriteLine("I am Parent");
    }
}
class Child1 : Parent
{
    internal void show()
    {
        display();
        Console.WriteLine("I am child-1");
    }
}
class
    Child2 : Parent
{
    internal void print()
    {
        display();
        Console.WriteLine("I am child-2");
    }
}

class demo
{
    static void Main()
    {
        Child1 c1 = new Child1();
        Child2 c2 = new Child2();
        c1.show();
        c2.print();
        Console.ReadKey();
    }
}