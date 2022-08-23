
//................Method Hiding..................
//.........( static to static to static )........ 

using System;
class grand
{
    protected static void show()
    {
        Console.WriteLine("Hi");
    }
}

class parent : grand
{
    protected new static void show()
    {
        grand.show();
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