
//.............Read Only Variable...........
//.........Progarm-2 (static variable)......


using System;
class Test
{
    readonly static int z;
    static Test()
    {
        z = 200;
    }
    static void Main()
    {
        Console.WriteLine(z);
        Console.ReadKey();
    }
}
