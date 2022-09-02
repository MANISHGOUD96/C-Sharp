
//................Partial Method..............
//...................File-1...................

using System;
 public partial class Demo
{
    public partial void Show();
    public partial void Display();
}


//................Partial Method..............
//...................File-2...................

using System;
public partial class Demo
{
    public partial void Show()
    {
        Console.WriteLine("Hi");
    }
}

//................Partial Method..............
//...................File-3...................

using System;
public partial class Demo
{
    public partial void Display()
    {
        Console.WriteLine("Hello");
    }
}


//................Partial Method..............
//....................File-4..................

using System;

public partial class Demo
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show();
        d.Display();
        Console.ReadKey();

    }
}