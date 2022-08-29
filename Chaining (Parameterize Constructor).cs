
//...............Chaining (Parameterize Constructor)................
//...............It menditory to pass base Keyword..................

using System;

class G
{
    public G(int x):base()
    {
        Console.WriteLine("Grand " + x);
    }
}

class P : G
{
    public P(int x):base(100)
    {
        Console.WriteLine("Father " + x);
    }
}


class C : P
{
    public C(int x):base(200)
    {
        Console.WriteLine("Child " + x);
    }

    static void Main()
    {
        C obj = new C(300);
        Console.ReadKey();
    }
}