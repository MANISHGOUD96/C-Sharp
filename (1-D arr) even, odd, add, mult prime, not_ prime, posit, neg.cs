using System;
class demo
{
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
        //...........................Print the Simple arr.............

        Console.WriteLine("..........Simple Arr............");

        i = 0;
        while (i < arr.Length)
        {
            Console.WriteLine(" " + arr[i]);
            i++;
        }

        //...............................gratest no.................

        Console.WriteLine("..........Largest No............");
        i = 0;
        int higest = arr[0];
        while (i < arr.Length)
        {
            if (arr[i] > higest)
                higest = arr[i];

            i++;
        }
        Console.WriteLine("Larget value:" + higest);


        //...............................smallest no.................

        Console.WriteLine("..........Smallest No............");
        i = 0;
        int small = arr[0];
        while (i < arr.Length)
        {
            if (arr[i] < small)
                small = arr[i];
            i++;
        }
        Console.WriteLine(" Smallest value:" + small);

        //...............................count Largest no.................

        Console.WriteLine("..........count Largest No............");
        i = 0;
        int largest = arr[0];
        int count = 0;
        while (i < arr.Length)
        {
            if (arr[i] > largest)
                count++;
            i++;
        }
        Console.WriteLine("arr[0] total largest :" + count);

        //...............................count smallest no.................

        Console.WriteLine("..........count smallest No............");
        i = 0;
        small = arr[0];
        count = 0;
        while (i < arr.Length)
        {
            if (arr[i] < small)
                count++;
            i++;
        }
        Console.WriteLine("arr[0] total smallest :" + count);

        //...............................count even and odd no.................

        Console.WriteLine("..........count even No............");
        i = 0;
        int even = 0, odd = 0;

        while (i < arr.Length)
        {
            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;
            i++;
        }
        Console.WriteLine("count Even no: " + even);
        Console.WriteLine("count odd no: " + odd);


        //...............................count positive & negative no.................

        Console.WriteLine("..........count positive No............");
        i = 0;
        int positive = 0, negative = 0;

        while (i < arr.Length)
        {
            if (arr[i] >= 0)
                positive++;
            else
                negative++;

            i++;
        }
        Console.WriteLine("count poitive no  :" + positive);
        Console.WriteLine("count negative no  :" + negative);

        //...............................addition of arr.................

        Console.WriteLine("..........Arr add............");

        int sum = 0;
        i = 0;
        while (i < arr.Length)
        {
            sum = sum + arr[i];
            i++;
        }
        Console.WriteLine("Sum Of arr: " + sum);

        //...............................Multiplication Of arr.................

        Console.WriteLine("..........Multiplication Of arr............");

        int mul = 1;
        i = 0;
        while (i < arr.Length)
        {
            mul = mul * arr[i];
            i++;
        }
        Console.WriteLine("Multiplication Of arr: " + mul);


        //...............................count prime no.................

        Console.WriteLine("..........prime Of arr............");


        int prime = 0, not_prime = 0;
        i = 0;
        while (i < arr.Length)
        {
           
            int num = arr[i] / 2;
            bool flag = true;
            int j = 2;
            while (j < num)
            {
                if (num % j == 0)
                {
                    flag = false;
                    break;
                }
                j++;
            }
            if (flag == true)
                prime++;
            else
                not_prime++;
            i++;
        }
        Console.WriteLine("Total prime no in arr: " + prime);
        Console.WriteLine("Total not_prime no in arr: " +not_prime);
    }
}