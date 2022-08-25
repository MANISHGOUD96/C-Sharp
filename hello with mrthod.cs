

using System;

/*
//................with out Parameter with out Return Type................... 
class demo
{
    static void m1()
    {
        Console.Write("Enter the string: ");
        string name = Console.ReadLine();

        Console.WriteLine(name);
    }
    static void Main()
    {
        m1();
    }

}
*/

/*
//................with  Parameter with out Return Type................... 

class demo
{
    static void M1(string name)
    {
        Console.WriteLine(name);    
    }
static void Main()
    {
        Console.Write("Enter the string: ");
        string name=Console.ReadLine();
        M1(name);

    }
}*/


/*/................with out Parameter with Return Type................... 

class demo
{
    static string name()
        {
        Console.Write("Enter the name: ");
        string name=Console.ReadLine();

        return name;

        }
      static void Main()
    {
        Console.WriteLine(name());
    }
}
*/


/*
//................with  Parameter with Return Type................... 

class demo
{
    static string name (string value)
    {
        return value;
    }
    static void Main()
    {
        Console.Write("Enter the Name: ");
        string value=Console.ReadLine(); 

        Console.WriteLine(name(value));
    }
}

*/

