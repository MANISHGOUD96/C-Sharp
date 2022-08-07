    using System;
class arr
{
    static int higest(int[] arr)
    {
        int count = 0;
        int higest = arr[0];
        int i = 0;
        while (i < arr.Length)
        {
            if (arr[i]>higest)
                higest = arr[i]; 
            i++;
        }
        return higest;

    }

    static void Main()
    {
        Console.Write("Enter the size of arr: ");
        int size=int.Parse(Console.ReadLine());
        int[]arr=new int[size]; 

        int i = 0;  
        while(i<arr.Length)
        {
            Console.Write("Enter the value: ");
            arr[i]=int .Parse(Console.ReadLine());  
            i++;
        }
        Console.WriteLine(higest(arr));
    }
}