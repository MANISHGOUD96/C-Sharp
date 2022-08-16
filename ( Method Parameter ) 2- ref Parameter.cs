
//..............Following Types of Method Parameter in C#..........

//.............. 2- ref Parameter................

using System;
class demo
{
    static void swap(ref int x,ref int y)
    { 
        int z = x;
            x = y;
            y = z;
        Console.WriteLine("Swap x and y: "+ x + " " + y);
    }
    static void Main()
    {
        Console.Write("Enetr the first value: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enetr the second value: ");
        int num2 = int.Parse(Console.ReadLine());
        swap(ref num1, ref num2);
        Console.WriteLine("Swap x and y in main method: "+ num1 + " " + num2);    
        Console.ReadKey();
    }
}