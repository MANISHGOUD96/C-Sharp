
//...................MultiLevel Inheritence..............

using System;
    class Client1
    {
        protected void show()
        {
            Console.WriteLine("Hello");
        }
    }
   class Client2 : Client1
   {
    protected void display()
    {
        Console.WriteLine("Hi");
    }

   } 
    class Demo : Client2
    {
        static void Main()
        {
            Demo d = new Demo();
            d.show();
            d.display();
            Console.ReadKey();
        }
    }
