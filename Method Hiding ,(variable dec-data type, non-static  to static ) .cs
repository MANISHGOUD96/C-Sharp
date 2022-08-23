//............Method Hiding(non-static to static)..........
//  if two variable inslize same name in method class.
//  both variable declared data Type.


using System;
class demo
{
    public int x = 100;
}

class test : demo
{
    new public int x=200;
        static void Main()
    {
        test t = new test();
        Console.WriteLine(t.x);
        demo d = new demo();
        Console.WriteLine(d.x);

        Console.ReadKey();
    }
}