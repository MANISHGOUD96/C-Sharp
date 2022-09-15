
//.............. Constant Prameter............
//...................Progarame-1...............

using System;


class Caonstantvar
{
  static void Main()
    {
        const int x = 100;
        // x = x + 2;  // error we not use constant variable as a third variable.

        int y = x + 2;
        Console.WriteLine(y);
        Console.ReadKey();
}


//..................Programe-2....................

class Demo
{
    const int z = 150;
    static void Main()
    {
        const int p = 2;
        const int c = p * z;
        Console.WriteLine(c);
        Console.ReadKey();
    }
}

