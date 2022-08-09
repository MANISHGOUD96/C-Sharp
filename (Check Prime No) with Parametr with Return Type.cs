
class prime
{
    static string result(int num)
    {
        string result;

        int n = num / 2;
        bool flag = true;
        int i = 1;
        while (i <= n)
        {
            if (n % i == 0)
            {
                flag = false;
                break;
            }
            i++;
        }
        if (flag == false)
            result = "Prime No";
        else
            result = "Not Prime No";
        return result;
    }

    static void Main()
    {
        System.Console.WriteLine("Enter the num");
        int num = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine(result(num));
        System.Console.ReadKey();
    }
}