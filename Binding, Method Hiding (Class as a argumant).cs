
//...................Binding(Method Hiding) ...................
//................create class as the argument..................


class Test
{
    public void Process()
    { 
        System.Console.WriteLine("2000"); 
    }
    public static void Show(Test test)
    {
        test.Process(); 
    }
}
class demo
{
    static void Main()
    {
        Test t=new Test();
        Test.Show(t);
    }
}