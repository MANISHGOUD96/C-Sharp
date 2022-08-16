
//Pelindrome Of String

using System;
class StringPalindrome
{
    static void Main()
    {

        string reverse = "";
        Console.Write("Enter the Value: ");
        String str = Console.ReadLine();

        int i = str.Length - 1;
        while (i >= 0)
        {
            reverse = reverse + str[i];
            i--;
        }

        if (reverse == str)
            Console.WriteLine("Pelindrome  String");
        else
            Console.WriteLine("Not Palindrome String");
        Console.ReadLine();
    }
}