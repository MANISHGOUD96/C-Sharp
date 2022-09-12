
/* Exception Handling*/

using System;
class Demo
{
    static void Main()
    {
        int result=0;
        Console.Write("Enter the Value Of first: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the Value Of Second: ");
        int second = int.Parse(Console.ReadLine());
        try
        {
            result = first / second;
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("Can Not Divided: " + e);
        }
       
        Console.WriteLine("All is Well");
        Console.ReadLine();
    }
}