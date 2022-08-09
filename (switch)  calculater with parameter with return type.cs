
using System;
class demo
{
    static int result(int num1, int num2, char choice)
    {
        int result = 0;
        switch (choice)
        {
            case '+':
                       result = num1 + num2;
                       break;


            case '/':
                        result = num1 / num2;
                        break;

            case '-':
                        result = num1 - num2;
                        break;

            case '*':
                        result = num1 * num2;
                        break;
            default :
                         result = 0;
                         break;
    }
         return result;
    }

    static void Main()
    {
        Console.WriteLine("enter the num1");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the num2");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the choice");
        char choice = char.Parse(Console.ReadLine());

        Console.WriteLine(result(num1, num2, choice));
        Console.ReadKey();
    }
}