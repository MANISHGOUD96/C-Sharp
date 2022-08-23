//............Method Hiding(non-static to static)..........
//  if two variable inslize same name in method class.
//  one variable declared data Type & one not declear data type.


using System;
class demo
{
    public int x = 100;
}

class test : demo
{
    test(){
             x=300;
        }
        static void Main()
    {
        test t = new test();
        Console.WriteLine(t.x);
        demo d = new demo();
        Console.WriteLine(d.x);

        Console.ReadKey();
    }
}