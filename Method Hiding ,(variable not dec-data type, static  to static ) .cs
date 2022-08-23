
//............Method Hiding(static to static)..........
//  if two variable inslize same name in method class.
//  one variable declared data Type & one not declear data type.


using System;
class demo
{
    public static int x = 100;
}

class test : demo
{
    test(){
             x=300;
          }

        static void Main()
    {
        Console.WriteLine(demo.x);
        Console.WriteLine(x);

        Console.ReadKey();
    }
}