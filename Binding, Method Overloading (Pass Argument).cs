
//...................Binding(Method Overloading) ..................
//..........................Pass with Parameter. ..........................
//.....................Type-1.........
class Test
{
    public  void Process(int num)
    { 
        System.Console.WriteLine(" Hello "+num); 
    }
}

class Mix : Test
{
    public  void Process(string num)
    {
        System.Console.WriteLine(" hi "+num);
    }
}

class demo
{
    static void Main()
    {
        Test t = new Mix();
        t.Process(500);

        Mix m = new Mix();
        m.Process("Chetu");
    }
}


/*

//..............Type-2...........................

class Test
{
    public  void Process(int num)
    { 
        System.Console.WriteLine(" Hello "+num); 
    }
}

class Mix : Test
{
    public  void Process(string num)
    {
        System.Console.WriteLine(" Hi "+num);
    }
}

class Dix:Mix
    {
    public void Process(char num)
    {
        base.Process("Manish");
        System.Console.WriteLine(" By " + num);
    }
}
class demo
{
    static void Main()
    {
        Test t = new Mix();
        t.Process(500);

        Dix d = new Dix();
        d.Process('C');
    }
}
*/