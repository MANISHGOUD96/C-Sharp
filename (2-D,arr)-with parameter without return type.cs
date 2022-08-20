using System;
class arr
{
    static void D2(int a, int b, int[,] arr)
    {
        Console.WriteLine("....................Print Arr..........................");
        Console.WriteLine();
        //................Print Arr....................
        int i = 0;
        while (i < arr.GetLength(0))
        {
            int j = 0;
            while (j < arr.GetLength(1))
            {
                Console.Write(" " + arr[i, j]);
                j++;
            }
            Console.WriteLine();
            i++;
        }

        //.................................Addition of arr........................................

        Console.WriteLine("....................Addition of Arr..........................");
        Console.WriteLine();

        // .............. addition of row ....................      
        int sum;
        i = 0;
        while (i < arr.GetLength(0))
        {
            sum = 0;
            int j = 0;
            while (j < arr.GetLength(1))
            {
                sum = sum + arr[i, j];
                j++;
            }
            Console.WriteLine("Sum of row {0} is: {1}", i + 1, sum);
            i++;
        }
        Console.WriteLine();

        // .............. addition of column ....................      
        i = 0;
        while (i < arr.GetLength(0))
        {
            sum = 0;
            int j = 0;
            while (j < arr.GetLength(1))
            {
                sum = sum + arr[j, i];
                j++;
            }
            Console.WriteLine("Sum of column {0} is: {1}", i + 1, sum);
            i++;
        }
        Console.WriteLine();

        // .............. addition of Primary digonals....................    

        sum = 0;
        i = 0;
        while (i < arr.GetLength(0))
        {

            int j = 0;
            while (j < arr.GetLength(1))
            {
                if (i == j)
                    sum = sum + arr[j, i];
                j++;
            }
            i++;
        }
        Console.WriteLine("Sum of Primary Digonals is: " + sum);
        Console.WriteLine();

        // .............. addition of seconadary digonals....................    

        sum = 0;
        i = 0;
        while (i < arr.GetLength(0))
        {
            int j = 0;
            while (j < arr.GetLength(1))
            {
                if (i + j == a - 1)
                    sum = sum + arr[j, i];
                j++;
            }
            i++;
        }
        Console.WriteLine("Sum of secondary Digonals is: " + sum);
        Console.WriteLine();

        //........................................Multiplication of arr..............................
        Console.WriteLine(".......................Multiplication of Arr.........................");
        Console.WriteLine();

        // .............. Multiplication of row ....................      
        int mul;
        i = 0;
        while (i < arr.GetLength(0))
        {
            mul = 1;
            int j = 0;
            while (j < arr.GetLength(1))
            {
                mul = mul * arr[i, j];
                j++;
            }
            Console.WriteLine("Multiplication of row {0} is: {1}", i + 1, mul);
            i++;
        }
        Console.WriteLine();

        // .............. Multiplication of column ....................      
        i = 0;
        while (i < arr.GetLength(0))
        {
            mul = 1;
            int j = 0;
            while (j < arr.GetLength(1))
            {
                mul = mul * arr[j, i];
                j++;
            }
            Console.WriteLine("Multiplication of column {0} is: {1}", i + 1, mul);
            i++;
        }
        Console.WriteLine();

        // .............. Multiplication of Primary digonals....................    

        mul = 1;
        i = 0;
        while (i < arr.GetLength(0))
        {

            int j = 0;
            while (j < arr.GetLength(1))
            {
                if (i == j)
                    mul = mul * arr[i, j];
                j++;
            }
            i++;
        }
        Console.WriteLine("Multiplication of Primary Digonals is: " + mul);
        Console.WriteLine();

        // .............. Multiplication of seconadary digonals....................    

        mul = 1;
        i = 0;
        while (i < arr.GetLength(0))
        {
            int j = 0;
            while (j < arr.GetLength(1))
            {
                if (i + j == a - 1)
                    mul = mul * arr[i, j];
                j++;
            }
            i++;
        }
        Console.WriteLine("Multiplication of secondary Digonals is: " + mul);
        Console.WriteLine();

        //........................................Count Even and Odd in arr..............................
        Console.WriteLine(".......................Count Even and Odd in Arr.........................");
        Console.WriteLine();

        int even = 0, odd = 0;
        i = 0;
        while (i < arr.GetLength(0))
        {
            int j = 0;
            while (j < arr.GetLength(1))
            {
                if (arr[i, j] % 2 == 0)
                    even++;
                else
                    odd++;
                j++;
            }
            i++;
        }
        Console.WriteLine("Total even no in arr is: " + even);
        Console.WriteLine("Total odd no in arr is: " + odd);

        Console.WriteLine();
        //........................................Count Positive and Negetive in arr..............................
        Console.WriteLine(".......................Count Positive and Negetive in Arr.........................");
        Console.WriteLine();

        int positive = 0, negative = 0;
        i = 0;
        while (i < arr.GetLength(0))
        {
            int j = 0;
            while (j < arr.GetLength(1))
            {
                if (arr[i, j] > 0)
                    positive++;
                else
                    negative++;
                j++;
            }
            i++;
        }
        Console.WriteLine("Total positive no in arr is: " + positive);
        Console.WriteLine("Total negative no in arr is: " + negative);

        Console.WriteLine();
        Console.WriteLine("....................Count Prime No or Not Prime No ..........................");
        //................Count Prime No or Not Prime No....................

        i = 0;
        int prime = 0, notprime = 0;
        while (i < arr.GetLength(0))
        {

            bool flag = true;
            int j = 0;
            while (j < arr.GetLength(1))
            {
                int k = 2;
                {
                    while (k <= arr[i, j] / 2)
                    {
                        if (arr[i, j] % k == 0)
                        {
                            flag = false;
                            break;
                        }
                        k++;
                    }
                    if (flag == true)
                        prime++;
                    else
                        notprime++;
                }

                j++;
            }
            Console.WriteLine();
            i++;
        }
        Console.WriteLine("Total PrimeNo in arr: " + prime);
        Console.WriteLine("Total Not PrimeNo in arr: " + notprime);


    }

    //.............Main Method.....................
    static void Main()
    {
        Console.Write("Enter the size of arr1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the size of arr2: ");
        int b = int.Parse(Console.ReadLine());

        int[,] arr = new int[a, b];

        int i = 0;
        while (i < arr.GetLength(0))
        {
            int j = 0;
            while (j < arr.GetLength(1))
            {
                Console.Write("Enter the value of arr[{0}][{1}]: ", i, j);
                arr[i, j] = int.Parse(Console.ReadLine());
                j++;
            }
            Console.WriteLine();
            i++;
        }
        D2(a, b, arr);
        Console.ReadKey();
    }
}
