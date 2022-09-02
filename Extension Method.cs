//.....................Extension Method.........................

//............User Already Declear this source file.............

using System;
class Test
{
    public void M1()
    {
        Console.WriteLine("Hi");
    }
    public void M2()
    {
        Console.WriteLine("Hello");
    }
    public void M3()
    {
        Console.WriteLine("Good Morning");
    }
}


//................Create Extension Method...............


using System;
static class Process
{
    public static void M4( this Test te )
    {
        Console.WriteLine("Manish Goud");
    }
    public static void M5(this Test te,string name)
    {
        Console.WriteLine(name);
    }
    public static void M6(this Test te, int Sal)
    {
        Console.WriteLine(Sal);
    }
}


//......................Main Method...................


class Demo
{
    static void Main()
    {
        Test t = new Test();
        //..........Call from User Method............

        t.M1();
        t.M2();
        t.M3();

        //..........Call from Extension Method.......

        t.M4();
        t.M5("Come in Chetu");
        t.M6(15000);


    }
}