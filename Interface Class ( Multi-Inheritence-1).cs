
//...................Interface Class...................
//.................( Multi Inheritence )...............
//.................Method Name Different...............

using System;
interface I1
{
    void Show();
}
interface I2
{
    void Display();
}
class Test : I1, I2
{
    public void Show()
    {
        Console.WriteLine("Hi");
    }

    public void Display()
    {
        Console.WriteLine("Hello");
    }

    static void Main()
    {
        Test t = new Test();
       t.Show();
        t.Display();
    }
}