using System;
class Test
{
    int x;  //non static variable find the memory class run time.


    static int y;  //in program using of static variable .
                   //static variable find memory in class to loading time.memory meet ony one time.

    public void show()
    {
        x = x + 1;
        y = y + 1;
        Console.WriteLine(x + " " + y);
    }
}
class demo
{
    static void Main()
    {
        Test t1 = new Test();
        Test t2 = new Test();
        Test t3 = new Test();
        t1.show();
        t2.show();
        t3.show();
        Console.ReadKey();
    }
}
