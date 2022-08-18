//...............Following Types of Method Parameter in C#.................
//...............7-params Parameter..................
using System;
class demo
{
    static void M1(params int []arr)
    {
        foreach (int data in arr)
        {
            Console.Write(" "+data);
        }
    }
    static void Main()
    {
        M1();
        M1(1);
        M1(2,3);
        M1(4,5,6); 
        M1(7,8,9,10);
    }
}

/*
// .............Search bthe given value in arr...........
using System;
class demo
{
    static bool M(int value,params int[] arr)
    {
        bool flag = false;
        foreach (int data in arr)
        {
            if (data == value)
            {
                flag = true;
                break;
            }  
        }
        return flag;
    }
    static void Main()
    {
        bool result =M(6, 4, 5, 6, 3, 7, 9);
        Console.Write(" " +result);
        Console.ReadKey();
    }
}
/*