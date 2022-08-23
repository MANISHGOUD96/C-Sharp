
//...........................Method Hiding.......................
//...............( non-static to non-static to static )..........

using System;
class grand
{
    protected  void show()
    {
        Console.WriteLine("Hi");
    }
}
class parent : grand
{
    protected new  void show()
    {
        base.show();
        Console.WriteLine("Hello");
    }
}
class child : parent
{
    static void Main()
    {
        child c = new child();
       c.show();
        Console.ReadKey();
    }
}