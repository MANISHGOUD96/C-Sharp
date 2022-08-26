//....................Adress Details.....................

using System;
class Adress
{
    private int houseNo;
    private string villageName;
    private int pinNo;

    public Adress(int houseNo, string villageName, int pinNo)
    {
        this.houseNo = houseNo;
        this.villageName = villageName;
        this.pinNo = pinNo;
    }

    public int GetHouseNo()
    {
           return houseNo;
    }
    public string GetVillageName()
    {
          return villageName;
    }

    public int GetPinNo()
    {
            return pinNo;
    }
    public override string ToString()
    {
        return houseNo + " " + villageName + " " + pinNo;
    }

}



//.......................Employee Details.........................

using System;
class Employee
{
    private int empNo;
    private string empName;
    private double empSal;
    private Adress empAdre;

    public Employee(int empNo, string empName, double empSal, Adress empAdre)
    {
        this.empNo = empNo;
        this.empName = empName;
        this.empSal = empSal;
        this.empAdre = empAdre;
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

    public Adress GetEmpAdre()
    {
            return empAdre;
    }
}


//.................Has-a Relationship...............
//................Using (Constructor(Getter)).............
//.....................Main Method..................
using System;
class Demo
{
    static void Main()
    {
        Console.WriteLine("........Enter Employee Details........");
        Console.WriteLine();

        Console.Write("Enter the Employee No: ");
        int no = int.Parse(Console.ReadLine());
        Console.Write("Enter the Employee Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the Employee Sal: ");
        double sel = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("........Enter Adress Details........");
        Console.WriteLine();

        Console.Write("Enter the House No: ");
        int hno = int.Parse(Console.ReadLine());
        Console.Write("Enter the Village Name: ");
        string vill = Console.ReadLine();
        Console.Write("Enter the Area Pin No: ");
        int pin = int.Parse(Console.ReadLine());

        Adress ad = new Adress(hno, vill, pin);
        Employee e = new Employee(no, name, sel, ad);

        Console.WriteLine();
        Console.WriteLine("........Show Employee Details........");
        Console.WriteLine();

        Console.WriteLine("Emp No is: " + e.GetEmpNo());
        Console.WriteLine("Emp Name is: " + e.GetEmpName());
        Console.WriteLine("Emp Sal is: " + e.GetEmpSal());

        Console.WriteLine();
        Console.WriteLine("........Show Adress Details........");
        Console.WriteLine();

        Console.WriteLine("Adress is: "+e.GetEmpAdre());

        Console.WriteLine("House No is: " + ad.GetHouseNo());
        Console.WriteLine("House Name is: " + ad.GetVillageName());
        Console.WriteLine("Pin No is: " + ad.GetPinNo());

        Console.ReadKey();

    }
}




