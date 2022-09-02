
//......................Factory Method...................
//.................( Adapted Design Pattern ).............

using System;
interface I1
{
    void Show();
    void Display();
    void Process();
    void Deta();
    void Sum();
}

class Dix : I1
{
    public void Show()
    {
        Console.WriteLine("Hi");
    }
    public void Display()
    {
        Console.WriteLine("Hello");
    }
    public void Process()
    {
        Console.WriteLine("Manish");
    }
    public void Deta()
    {
        Console.WriteLine("good Maorning");

    }
    public void Sum()
    {
        int a = 5, b = 10;
        int c = a + b;
        Console.WriteLine(c);
    }
}

class Demo
{
    static void Main()
    {
        Dix a= new Dix();
        a.Show();

        Dix p = new Dix();
        p.Process();

        Dix s = new Dix();
        s.Sum();

        Console.ReadKey();
    }
}
