
//...............Following Types of Method Parameter in C#.................
//...............4-default Parameter..................
using System;
class demo
{
    static void M1(dynamic data)
    {
        Console.WriteLine(data);
    }
    static void Main()
    {
        M1(100);
        M1("Manish");
        M1(false);
        M1(55.521); 
        M1('A');
    }
}