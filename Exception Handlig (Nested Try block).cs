using System;

class test
{
    static void deb()
    {
        try
        {
            Console.Write("Eneter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Eneter the second number: ");
            int second = int.Parse(Console.ReadLine());
            int result = first / second;
            Console.WriteLine("Result is Division: " + result);
            try
            {
                int[] arr = { 101, 102, 103, 104, 105 };
                Console.Write("Enter the index number: ");
                int index = int.Parse(Console.ReadLine());

                int result1 = arr[index];

                Console.WriteLine("Result is Index Value: " + result1);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Plz check index number");
            }
            finally
            {
                Console.WriteLine("Ineer finally block");
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can not divaided by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Can not Pass the Character value");
        }
        finally
        {
            Console.WriteLine("Out finally block");
        }
        Console.ReadKey();
    }
}