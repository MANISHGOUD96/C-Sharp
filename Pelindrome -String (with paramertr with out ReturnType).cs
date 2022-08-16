
//Pelindrome String with paramertr with out ReturnType. 

using System;
class StringPalindrome
{
    static void pelindrome(string str)
    {
        string reverse = "";
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
    }
    static void Main()
    {
        Console.Write("Enter the Value: ");
        String str = Console.ReadLine();
        pelindrome(str);
        Console.ReadLine();
    }
}