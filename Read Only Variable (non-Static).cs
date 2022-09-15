
//.............Read Only Variable.............
//.......Progarm-1 (non static variable)......

using System;

class Show
{
    readonly  int x;
    Show(int x)
    {
        this.x = x;
    }
    static void Main()
    {
        Show s = new Show(100);
        Console.WriteLine(s.x);
        Console.ReadKey();
    }
}

