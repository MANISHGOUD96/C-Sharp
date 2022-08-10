//Reverse String
 
using System;
    class demo
    {
        static void Main()
        {
            string  str = "", reverse = "";
            Console.Write("Enter a Word: ");
            str = Console.ReadLine();
            int i = 0;
            i = str.Length-1;
            while (i >= 0)
            {
                reverse = reverse + str[i];
                i--;
            }
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }
    }
