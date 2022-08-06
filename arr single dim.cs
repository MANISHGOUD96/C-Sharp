class arr
{
    static void Main()
    {
        System.Console.Write("Enter the size of arry: ");
        int size = int.Parse(System.Console.ReadLine());
        int[] arr = new int[size];
        int i = 0;
        do 
        {
            System.Console.Write("Enter the value: ");
             arr[i] = int.Parse(System.Console.ReadLine());
            i++;
        } while (i < arr.Length) ;
            System.Console.WriteLine("..................");
    //.........................Print the simple arr..........
    
        i= 0;
        do
        {
            System.Console.WriteLine(arr[i]+" ");
            i++;
        } while (i < arr.Length);
        System.Console.WriteLine("..................");

    //.........................Count even odd no..........  

       int count=0,num;
        arr[0] = num;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > num)
                count++;
        }
        System.Console.WriteLine(count)
        System.Console.ReadLine();
    }
}

