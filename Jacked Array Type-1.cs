
//........................Jacked Arry Program.......................
//................................Type-1............................

using System;
class Demo
{
    static void Main()
    {

        int[][] arr;
        arr = new int[3][];
        arr[0] = new int[3];
        arr[1] = new int[2];
        arr[2] = new int[4];

        arr[0][0] = 1;
        arr[0][1] = 2;
        arr[0][2] = 3;

        arr[1][0] = 9;
        arr[1][1] = 7;

        arr[2][0] = 6;
        arr[2][1] = 5;
        arr[2][2] = 4;
        arr[2][3] = 8;

        for(int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j<arr[i].Length; j++)
            {
                Console.Write(" " + arr[i][j]);
            }
            Console.WriteLine();
        }
    }
}
