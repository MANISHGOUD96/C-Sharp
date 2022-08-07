class method1
{
    static int result()
    {
        System.Console.Write("Eneter the num1: ");
        int num1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Eneter the num1: ");
        int num2 = int.Parse(System.Console.ReadLine());
        System.Console.Write("Eneter the choice: ");

        char choice = System.Convert.ToChar(System.Console.ReadLine());
        int result = 0;
        switch (choice){
            case '+':
                             result = num1 + num2;
                             break;
            case '-':
                             result = num1 - num2;
                             break;
            case '*':
                             result = num1 * num2;
                             break;
            case '/':
                             result = num1 / num2;
                             break;
            default :
                             result = 0;
                             break;
    }
               return result;
            }
    static void Main()
    {
       
        System.Console.WriteLine(result());
    } 
}