using System;
class demo
{
    static int [] result (int []arr)
    { 
        return arr;
    }
    static void Main()
    {
        System.Console.Write("Enter the size: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        int i = 0;
        while (i < arr.Length)
        {
            Console.Write("Enter the value: ");
            arr[i] = int.Parse(Console.ReadLine());
            i++;
        }

         int[] srr=new int[size];
         srr=result(arr);

        i = 0;  
        while(i<arr.Length)
        {
            Console.WriteLine(arr[i]);
            i++;
        }
    } 
}