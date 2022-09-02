
//................Single inheritence..............
//.............Table (count even & Odd)...........
using System;
class Parent
{
   public static  void Show(int num)
    {
        int i = 1;
        int table;
        int odd = 0, even = 0;
        while (i <= 10)
        {
             table = num * i;
            Console.WriteLine(num + " * " + i + " = " + table);
            i++;

            if (table % 2 == 0)
                even++;
            else
                odd++;
        }
        Console.WriteLine("Total Even No: " + even);
        Console.WriteLine("Total Odd No: " + odd);
    }
}

class Child : Parent
{
    static void Main()
    {
        
        Console.Write("Enetr the number Print table: ");
        int n = int.Parse(Console.ReadLine());
        Show(n);
    }
}