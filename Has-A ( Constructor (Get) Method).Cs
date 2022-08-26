//....................Adress Details.....................

using System;
class Adress
{
    private int houseNo;
    private string villageName;
    private int pinNo;

     public Adress(int houseNo, string villageName, int pinNo)
    {
        this.houseNo= houseNo;
        this.villageName= villageName;
        this.pinNo= pinNo;
    }

    public int HouseNo
    {
        get
        {
            return houseNo;

        }
    }
    public string VillageName
    {
            get
        {
            return villageName;
        }
    }

    public int PinNo
    {
        get
        {
            return pinNo;

        }
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

    public Adress EmpAdre
    {
        get
        {
            return empAdre;

        }
    }
}




//.................Has-a Relationship...............
//................Using ( Constructor - Get Method).............
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
        string vill= Console.ReadLine();
        Console.Write("Enter the Area Pin No: ");
        int pin = int.Parse(Console.ReadLine());

        Adress ad = new Adress(hno, vill, pin);
        Employee e = new Employee (no,name,sel,ad);

        Console.WriteLine();
        Console.WriteLine("........Show Employee Details........");
        Console.WriteLine();

        Console.WriteLine("Emp No is: " + e.EmpNo);
        Console.WriteLine("Emp Name is: " + e.EmpName);
        Console.WriteLine("Emp Sal is: " + e.EmpSal);

        Console.WriteLine();
        Console.WriteLine("........Show Adress Details........");
        Console.WriteLine();

        Console.WriteLine("Adress is: " );

        Console.WriteLine("House No is: " + ad.HouseNo);
        Console.WriteLine("House Name is: " + ad.VillageName);
        Console.WriteLine("Pin No is: " + ad.PinNo);

        Console.ReadKey();

    }
}
