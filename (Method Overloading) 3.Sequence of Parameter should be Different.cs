using System;
// Method Overloading
// 3.Sequence of Parameter should be Different.
class demo
{
    void show(int x, string Name)
    {
        Console.WriteLine(x + " " + Name);
    }

  void show(string Name,int x)
    {
        Console.WriteLine(x +" " + Name);
    }

    static void Main()
    {
        demo d = new demo();
        Console.Write("Enter the value of x: ");
         int x = int.Parse(Console.ReadLine());

        Console.Write("Enter the Name: ");
        string Name=Console.ReadLine();

        d.show(x,Name);
        d.show(Name, x);

        Console.ReadKey();

    }
}
