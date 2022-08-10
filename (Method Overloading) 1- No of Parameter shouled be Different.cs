 //Method Overloading
 // 1.Number of Parameter should be same.


using System
class demo
{
    int sum(int x,int y)
    {
        return x + y;
    }

    int sum(int x, int y,int z)
    {
        return x + y+z;
    }

    int sum(int x, int y,int z, int a)
    {
        return x + y+z+a;
    }
    static void Main()
    {
        demo d = new demo();
        Console.Write("Enter the value of x: ");
         int x = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of y: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of z: ");
        int z = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Addition of x,y: "+d.sum(x , y));
        Console.WriteLine("Addition of x,y,z: "+d.sum(x,y,z));
        Console.WriteLine("Addition of x,y,z,a: "+d.sum(x,y,x,a));

        Console.ReadKey();

    }
}