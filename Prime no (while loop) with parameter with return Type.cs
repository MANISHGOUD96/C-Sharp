using System;
class method1
{
    static string result (int num)
    {
        string result;
        bool flag=true;
        int i=2;
        while(i<num/2)
        {
            if(num%i==0)
                flag=false;
                break;
            i++;
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