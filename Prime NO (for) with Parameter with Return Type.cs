using System;
class method1
{
    static string result (int num)
    {
        string result;
        bool flag=true;
        for(int i=2;i<num/2;i++)
        {
            if(num%i==0)
                flag=false;
        }
        if (flag == true)
        
            result="Prime number";
        
        else
        
            result="Not prime no";
        
        return result;

    }
 static void Main()
    {
        Console.Write("Enter the num: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(result(num));
    }
}