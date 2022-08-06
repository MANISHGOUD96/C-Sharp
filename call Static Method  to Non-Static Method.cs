using System;
class Method
{
   static void value()
    {
        Console.Write("value of p: ");
          int a = int.Parse(Console.ReadLine());
        Console.Write("value of s: ");
        int b = int.Parse(Console.ReadLine());
        int e = a * b;
        Console.WriteLine(e);
    }
    void add()
    {
        value();
        Console.Write("value of a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("value of b: ");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        Console.WriteLine(c);
    }
    static void Main()
    {
        Method m = new Method();
        m.add();
        Console.ReadLine();
    }
}
