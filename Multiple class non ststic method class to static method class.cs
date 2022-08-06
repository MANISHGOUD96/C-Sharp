using System;
class makg
{
   public  void add()
    {
        Console.Write("Enter number a: ");
        int a=int.Parse(Console .ReadLine());
        Console.Write("Enter number b: ");
        int b = int.Parse(Console.ReadLine());
        int c=a+b;
        Console.WriteLine(c);
    }
}
class lkg
{

    public static  void mul()
    {
        makg m=new makg();
        m.add();

        Console.Write("Enter valued d: ");
        int d=int.Parse(Console.ReadLine());
        Console.Write("Enter number e : ");
        int e = int.Parse(Console.ReadLine());
        int f = d *e;
        Console.WriteLine(f);
    }
}

class demo
{
    static void Main()
    {
            
        lkg.mul();
    }
}