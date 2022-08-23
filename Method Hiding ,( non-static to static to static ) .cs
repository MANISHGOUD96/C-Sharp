
//................Method Hiding..................
//......( non-static to static to static ).......

using System;
class grand
{
    public  void show()
    {
        Console.WriteLine("Hi");
    }
}
class parent : grand
{
    protected new static void show()
    {
        grand g = new grand();
        g.show();
        Console.WriteLine("Hello");
    }
}
class child : parent
{
    static void Main()
    {
       show();
        Console.ReadKey();
    }
}