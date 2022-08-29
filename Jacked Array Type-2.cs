
//........................Jacked Arry Program.......................
//................................Type-2............................

using System;
class Demo
{
    static void Main()
    {

        int[][] arr =  { new int[] {1, 2, 3 }, new int[] {4,5}, new int[] {8,9,6,3} };

        for(int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j<arr[i].Length; j++)
            {
                Console.Write(" " + arr[i][j]);
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
