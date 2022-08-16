
//Pelindrome Of String with Parameter Without Return Type.

using System;
class StringPalindrome
{
    static string pelindrome(string str)
    {
        string pelindrome;
        string reverse = " ";
        int i = str.Length - 1;
        while (i >= 0)
        {
            reverse = reverse + str[i];
            i--;
        }
        if (reverse == str)
           pelindrome="Pelindrome String";
        else
            pelindrome="Not Palindrome String";

        return pelindrome;
    }
    static void Main()
    {
        Console.Write("Enter the Value: ");
        String str = Console.ReadLine();
       Console.WriteLine(pelindrome(str));
        Console.ReadLine();
    }
}