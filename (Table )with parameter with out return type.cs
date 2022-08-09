class demo
{
    static void table(int num)
    {
        int i = 1;
        while (i <= 10)
        {
            System.Console.WriteLine(i + "*" + num + "=" + num * i);
            i++;
        }
  }
    static void Main()
    {
        System.Console.Write("Enter the num: ");
        int num = int.Parse(System.Console.ReadLine());
        table(num);
        System.Console.ReadKey();
    }
}