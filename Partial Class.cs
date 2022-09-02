
//................Partial Class..............
//...................File-1...................

using System;
 public partial class employee
{
    private int empNo;
    private string empName;
    private double empSal;
  public employee(int empNo,string empName,double empSal)
    {
        this.empNo = empNo;
        this.empName = empName;
        this.empSal = empSal;
    }
}


//................Partial Class..............
//...................File-2...................

using System;
public partial class employee
{
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
}


//................Partial Class..............
//...................File-3..................

using System;

public partial class employee
{
    static void Main()
    {
        employee e = new employee(105,"Mainsh",15000.51);
        Console.WriteLine("Employee Id no is: " + e.GetEmpNo());
        Console.WriteLine("Employee Name is: " + e.GetEmpName());
        Console.WriteLine("Employe Selary is: " + e.GetEmpSal());

    }
}