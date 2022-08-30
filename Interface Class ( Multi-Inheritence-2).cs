
//...................Interface Class...................
//.................( Multi Inheritence )...............
//...................Method Name Same..................

using System;
interface I1
{
    void Show();
}
interface I2
{
    void Show();
}
class Test : I1, I2
{
    public void Show()
    {
        Console.WriteLine("Hi");
    }
    static void Main()
    {
        Test t = new Test();
        t.Show();
    }
}