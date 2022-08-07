class method1
{
  static int result(int num1,int num2,char choice)

    {
        int result = 0;
        if (choice == '+')
            result = num1 + num2;
        else if (choice == '-')
            result = num1 - num2;
        else if (choice == '*')
            result = num1 * num2;
        else if (choice == '/')
            result = num1 / num2;
        else
            result = 0;
        return result;

            }
    static void Main()
    {
        System.Console.Write("Eneter the num1: ");
        int num1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Eneter the num2: ");
        int num2 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Eneter the choice: ");
        char choice = System.Convert.ToChar(System.Console.ReadLine());

        System.Console.WriteLine(result(num1, num2, choice));

    } 
}