using System;
class student
{
    int rollNo;
      public student()
    {
        rollNo = 101; 
    }
    public void show()
    {
        Console.WriteLine(this.rollNo);
    }
}

class demo{
    static void Main()
    {
        student t1 = new student();
        student t2 = new student();
        student t3 = new student();

        t1.show();
        t2.show();
        t3.show();
        Console.ReadKey();
    }
}