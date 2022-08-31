
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

    public int GetEmpNo()
    {
            return empNo;
    }
    public string GetEmpName()
    {
        return empName;    
    }
    public double GetEmpSal()
    {
            return empSal;
    }
    public string GetEmpAdr()
    {
            return empAdr;
    }
}

class Demo
{
    static void Main()
    {
        Show d = new Show(1005,"Mukesh Kumar Singh",15000.251,"Vill-Barawa Babu, Post-Pipraich, Dist-Kushinagar(278009)");
        Console.WriteLine("Employee Id No is: " + d.GetEmpNo());
        Console.WriteLine("Employee Name is: " + d.GetEmpName());
        Console.WriteLine("Employee Selary is: " + d.GetEmpSal());
        Console.WriteLine("Employee Adress is: " + d.GetEmpAdr());

        Console.ReadKey();
    }
}