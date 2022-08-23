
//............Method Hiding(static to static)..........
//  if two variable inslize same name in method class.
//  both variable declared data Type. 


using System;
class demo
{
    public static int x = 100;
}

class test : demo
{ 
    public static new int x = 200;
    static void Main()
    {
     
    Console.WriteLine(demo.x);
    Console.WriteLine(x);

    Console.ReadKey();
    }
}