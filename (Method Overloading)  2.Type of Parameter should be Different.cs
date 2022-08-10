using System;
// Method Overloading
// 2.Type of Parameter should be Different.
class demo
{
    int show(int x,int y)
    {
        return x ;
    }

    string show(string Name)
    {
        return Name;
    }

    static void Main()
    {
        demo d = new demo();
        Console.Write("Enter the value of x: ");
         int x = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of y: ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("Enter the Name: ");
        string Name=Console.ReadLine();

        Console.WriteLine("Addition of x,y: "+d.show(x,y));
        Console.WriteLine("Print the Name: " + d.show(Name));

        Console.ReadKey();

    }
}
