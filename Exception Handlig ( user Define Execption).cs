using System;

class demo
{
    class CheckExtension : ApplicationException
    {
        public override string ToString()
        {
            return "Age can not be negative";
        }
    }
    static void Main()
    {
        Console.Write("Eneter the number: ");
        int no = int.Parse(Console.ReadLine());
        Console.Write("Eneter the Name: ");
        string name = Console.ReadLine();
        try
        {
            Console.Write("Enter the Age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                CheckExtension exc = new CheckExtension();
                throw exc;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No is: " + no);
                Console.WriteLine("Name is: " + name);
                Console.WriteLine("Age is: " + age);
            }
        }
        catch (CheckExtension e)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("All is well");
        Console.ReadKey();
    }
}