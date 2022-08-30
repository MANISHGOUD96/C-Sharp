
//......................Factory Method...................
//.................( Proto Design Pattern ).............

using System;
class Test
{
    private Test() { }
    public void Show()
    {
        Console.WriteLine("Hello  "+this.GetHashCode());
    }

    public static Test GetObj()
    {
        Test te = new Test();
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

    }
}