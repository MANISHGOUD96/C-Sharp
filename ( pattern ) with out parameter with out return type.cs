class pattern
{
    static void M1()
    {
        int ctr;
        int ptr;
            ctr = 0;
        while (ctr < 3)
        {
            ptr = 0;
            while (ptr <= ctr)
            {
                System.Console.Write("A");
                ptr++;
            }
            System.Console.WriteLine();
            ctr++;
        }
    }

    static void Main()
    {
        M1();
        System.Console.ReadKey();
    }
}