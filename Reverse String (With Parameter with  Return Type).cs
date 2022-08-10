
//Reverse String (With Parameter with  Return Type)

using System;
 class demo
 {
    static string reverse(string str)
    {
        string reverse="";
        int i = 0;
        i = str.Length - 1;
        while (i >= 0)
        {
            reverse = reverse + str[i];
            i--;
        }
        return reverse;     
    }
    static void Main()
    {
        Console.Write("Enetr the string: ");
        string str = Console.ReadLine();
        Console.WriteLine("Reverse String is:" +reverse(str));
        Console.ReadKey();
    }
 }
