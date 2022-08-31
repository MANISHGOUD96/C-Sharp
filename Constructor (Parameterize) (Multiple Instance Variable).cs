
//...................Constructor (Parameterize).................
//..................(Multiple instance Variable)................

using System;
class Demo
{
    private int num;
    public Demo(int num)
    {
        this.num = num;
    }

    public void Show()
    {
        Console.WriteLine("Num is: " + num);
    }
}
class Display
{
    static void Main()
    {
      
        Demo d1 = new Demo(101);
        Demo d2 = new Demo(103);
        Demo d3 = new Demo(104);
        Demo d4 = new Demo(105);
        Demo d5 = new Demo(106);
        d1.Show();
        d2.Show();
        d3.Show();
        d4.Show();
        d5.Show();
    }
}