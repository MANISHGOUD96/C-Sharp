
//......................Factory Method...................
//.................( Single tun Design Pattern ).............

using System;
class Test
{
    private Test() { }
    private static Test te; 
    public void Show()
    {
        Console.WriteLine("Hello  "+this.GetHashCode());
    }

    public static Test GetObj()
    {
        if (te == null)
        {
             te = new Test();
        }
        return te;
    }
}

class Demo
{
    static void Main()
    {
        Test t = Test.GetObj();
        t.Show();
        Test t1 = Test.GetObj();
        t1.Show();
        Test t2 = Test.GetObj();
        t2.Show();

        Console.ReadKey();
    }
}