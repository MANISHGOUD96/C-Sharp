//...............Following Types of Method Parameter in C#.................
//...............3-out Parameter..................
using System;
class demo
{
    static void cal(int x,int y,out int sum, out int sub, out int mul, out int div)
    {
        sum = x + y;
        sub = x - y;
        mul = x * y;
        div = x / y;
    }
    static void Main()
    {
        int s, su, mu, di;
        cal(20, 10, out s, out su, out mu, out di);
        Console.WriteLine("Sum is: " +s);
        Console.WriteLine("Sub is: "+su);
        Console.WriteLine("Mul is: "+ mu);
        Console.WriteLine("Div is: "+ di);
        Console.ReadKey();
    }
}