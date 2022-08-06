 // 1st Class Method......(Create)

using System;

namespace N1
{
    class Method
    {
        public  void div()  // Non static Method.
        {
            Console.Write("value of a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("value of b: ");
            int b = int.Parse(Console.ReadLine());
            int e = a + b;
            Console.WriteLine("Addition: "+e);
            Console.WriteLine();
        }
    }
}

namespace N2
{
    class Method
    {
        public static void sub()       // Static Method.

        {
            N1.Method m=new N1.Method();      // call non static method to sattic Method.
            m.div();

            Console.Write("value of g: ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("value of h: ");
            int h = int.Parse(Console.ReadLine());
            int c = g - h;
            Console.WriteLine("Substeraction: "+c);
            Console.WriteLine();
        }
    }
}

namespace N3
{
    class Method
    {
        public static void mul()    // Static Method.
        {
            N2.Method.sub();     // Call Static Method to Static Method..

            Console.Write("value of r: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("value of s: ");
            int s = int.Parse(Console.ReadLine());
            int z = r * s;
            Console.WriteLine("Multiplication: "+z);
            Console.WriteLine();
        }
    }
}

namespace N4
{
    class Method
    {
        public  void div()    // Non static Method.

        {
            Console.Write("value of k: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("value of l: ");
            int l = int.Parse(Console.ReadLine());
            int z = k /l ;
            Console.WriteLine("Division: " + z);
            Console.WriteLine();
        }
    }
}

// 2nd Class demo...........(Create Main Function)

using System;
using N1;
using N2;
using N3;
using N4;
class demo
{
    static void Main()
    {
        N3.Method.mul();     // Call Static Method to Static Method..

        N4.Method m = new N4.Method();     // call non static method to sattic Method.
        m.div();
 
        Console.ReadLine();
    }
}


