using System;

class args
{
    static void Main(string []args)
    {
        int num1 = int.Parse(args[0]);
        int num2 = Convert.ToInt32(args[1]);
        int num3 = num1 + num2;
        Console.WriteLine("Result is: " + num3);
    }
}
