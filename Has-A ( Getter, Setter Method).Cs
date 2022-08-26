
//................Adress Class..............

using System;
class Adress
{
    private int houseNo;
    private string houseName;
    private int pinNo;

    public void SteHouseNo(int houseNo)
    {
        this.houseNo=houseNo;
    }
    public void SteHouseName(string houseName)
    {
        this.houseName = houseName;
    }
    public void StePinNo(int pinNo)
    {
        this.pinNo = pinNo;
    }

    public int GetHouseNo()
    {
        return this.houseNo;
    }
    public string GetHouseName()
    {
        return this.houseName;
    }
    public int GetPinNo()
    {
        return this.pinNo;
    }

    public override string ToString()
    {
        return houseNo+" "+houseName+" "+pinNo;
    }
}

 
//.................Employee class.........................

using System;
class Employee
{
    private int empNo;
    private string empName;
    private double empSal;
    private Adress empAdress;


    public void SetEmpNo(int empNo)
    {
        this.empNo = empNo;
    }

    public void SetEmpName(string empName)
    {
        this.empName = empName;
    }
    public void SetEmpSal(double empSal)
    {
        this.empSal = empSal;
    }
    public void SetEmpAderss(Adress empAdress)
    {
        this.empAdress = empAdress;
    }


    public int GetEmpNo()
    {
        return this.empNo;
    }
    public string GetEmpName()
    {
        return this.empName;
    }
    public double GetEmpSal()
    {
        return this.empSal;
    }
    public Adress GetEmpAdress()
    {
        return this.empAdress;
    }
}



//.................Has-a Relationship...............
//................Using ( Setter Getter ).............
//.....................Main Method..................


using System;
class Demo
{
    static void Main()
    {
     
        Console.WriteLine("........Enter Employee Details........");
        Console.WriteLine();

        Employee e = new Employee();
        Console.Write("Enter the Employee No: ");
        int no = int.Parse(Console.ReadLine());
        Console.Write("Enter the Employee Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the Employee Sal: ");
        double  sal= double.Parse(Console.ReadLine());
        e.SetEmpNo(no);
        e.SetEmpName(name);
        e.SetEmpSal(sal);

        Console.WriteLine();
        Console.WriteLine("........Enter Adress Details........");
        Console.WriteLine();

        Adress a = new Adress();
        Console.Write("Enter the House No: ");
        int hno = int.Parse(Console.ReadLine());
        Console.Write("Enter the Village Name: ");
        string hname = Console.ReadLine();
        Console.Write("Enter the Area Pin No: ");
        int pin = int.Parse(Console.ReadLine());
        a.SteHouseNo(hno);
        a.SteHouseName(hname);
        a.StePinNo(pin);

        Console.WriteLine();
        Console.WriteLine("........Show Employee Details........");
        Console.WriteLine();

        Console.WriteLine("Emp No is: " + e.GetEmpNo());
        Console.WriteLine("Emp Name is: " + e.GetEmpName());
        Console.WriteLine("Emp Sal is: " + e.GetEmpSal());

        Console.WriteLine();
        Console.WriteLine("........Print Adress Details........");
        Console.WriteLine();

        Console.WriteLine("Adress is: " + e.GetEmpAdress());

        Console.WriteLine("House No is: " + a.GetHouseNo());
        Console.WriteLine("House Name is: " + a.GetHouseName());
        Console.WriteLine("Pin No is: " + a.GetPinNo());

        Console.ReadKey();
    }
} 