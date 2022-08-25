
//...................Binding(Method Overriding) ..................
//..................create class as the argument..................
class Test
{
    public virtual void Process()
    { 
        System.Console.WriteLine("2000"); 
    }

    public static void Display(Test test)
    {
        test.Process(); 
    }
}

class Mix : Test
{
    public override void Process()
    {
        System.Console.WriteLine("2010");
    }
}
class demo
{
    static void Main()
    {
        Test t=new Test();
        Test.Display(t);

        Mix m = new Mix();
        Test.Display(m);
    }
}