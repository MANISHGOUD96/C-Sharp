
//...............Constructor Chaining....................
//........It consist by default base Keyword.............

using System;

class G
{
    public G()
    {
        Console.WriteLine("Grand");
    }
}
class P : G
{
    public P()
    {
        Console.WriteLine("Father");
    }
}

class C : P
{
    public C():base()
    {
        Console.WriteLine("Child");
    }

    void Show()
    {
        Console.WriteLine("HI");
    }
    static void Main()
    {
        C obj = new C();
        obj.Show();
        Console.ReadKey();
    }
}