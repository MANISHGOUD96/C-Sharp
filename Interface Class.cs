
//...................Interface Class....................
//..................( Abstract )....................

using System;
interface M
{
    public abstract void Show();
    void Display();
}

class Demo : M
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
        M obj =new Demo();
        obj.Show();
        obj.Display();
    }
}