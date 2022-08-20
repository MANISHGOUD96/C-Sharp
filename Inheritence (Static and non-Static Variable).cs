using System;
using parent;
using child1;
using child2;

//................Parent class.................

namespace parent
{
    class Parent
    {
        protected int x = 10;
        protected static int y = 15;
    }
}

// .................child-1 class............


namespace child1
{
    class Child1 : Parent
    {
        internal static void show()
        {
            Child1 c1 = new Child1();
            Console.WriteLine("First Child is: ");
            Console.WriteLine(c1.x + " " + y);
        }
    }
}

// .................child-2 class............

namespace child2
{
    class Child2 : Parent
    {
        internal static void display()
        {
            Child2 c2 = new Child2();
            Console.WriteLine("First Child is: ");
            Console.WriteLine(c2.x + " " + y);
        }
    }
}

//...............client class(Main class).....................
namespace n1
{
    class client
    {
        static void Main()
        {
            Child1.show();
            Child2.display();
            Console.ReadKey();
        }
    }
}