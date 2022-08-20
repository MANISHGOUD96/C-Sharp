    
  //...................Single Inheritence..............
 
 
   using System;
    class Client
    {
        protected void show()
        {
            Console.WriteLine("Hello");
        }
    }

    class Demo : Client
    {
        static void Main()
        {
            Demo d = new Demo();
            d.show();
            Console.ReadKey();
        }
    }
