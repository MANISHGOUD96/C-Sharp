
using System;
class Demo
{
    static void Main()
    {
        try
        {
        int[] arr = { 101, 102, 103, 104, 105 };
        Console.Write("Enter the index number: ");
        int index = int.Parse(Console.ReadLine());

        int  result = arr[index];

        Console.WriteLine("Result is: " + result);
        }

        // This is use of the find the Index type handling error

        catch (IndexOutOfRangeException )
        {
            Console.WriteLine("Please check the index number" );
        }

        // This is use of the find the character type handling error

        catch (FormatException)
        {
            Console.WriteLine("Can not pass the character value");
        }

        // This is use when the We not use any type of handling

      catch(Exception e)
        {
            Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("All is Well");
        Console.ReadLine();
    }
}