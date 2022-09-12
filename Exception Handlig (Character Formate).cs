
using System;
class Demo
{
    static void Main()
    {
       
       
            int result = 0;
            Console.Write("Enter the Value Of first: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter the Value Of Second: ");
            int second = int.Parse(Console.ReadLine());
        try 
        { 
            result = first / second;
            Console.WriteLine("Result is: " + result);
        }
       /* catch (DivideByZeroException)
        {
            Console.WriteLine("Can Not Divided to zero: ");
        }
        catch (FormatException)
        {
            Console.WriteLine("Can not pass character type of value");
        }*/
        finally
        {
            Console.WriteLine("All is Well");
        }
        Console.ReadLine();
    }
}