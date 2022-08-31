
//...................Constructor (Parameterize).................
//.........................(Get Method).........................

using System;
class Show
{
    private int empNo;
    private string empName;
    private double empSal;
    private string empAdr;
    public Show(int empNo, string empName, double empSal, string empAdr)
    {
        this.empNo = empNo;
        this.empName = empName;
        this.empSal = empSal;
        this.empAdr = empAdr;
    }

    public int EmpNo
    {
        get
        {
            return empNo;
        }
    }
    public string EmpName
    {
        get
        {
            return empName;
        }
    }
    public double EmpSal
    {
        get
        {
            return empSal;
        }
    }
    public string EmpAdr
    {
        get
        {
            return empAdr;
        }
    }
}

class Demo
{
    static void Main()
    {
        Show d = new Show(101,"Mukesh  Singh",15000.251,"Vill-Barawa Babu, Post-Pipraich, Dist-Kushinagar(278009)");
        Console.WriteLine("Employee Id No is: " + d.EmpNo);
        Console.WriteLine("Employee Name is: " + d.EmpName);
        Console.WriteLine("Employee Selary is: " + d.EmpSal);
        Console.WriteLine("Employee Adress is: " + d.EmpAdr);

        Console.ReadKey();
    }
}