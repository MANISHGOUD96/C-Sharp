// ............Adress Class.............
using System;
class Adress
{
    private int houseNo;
    private string villageName;
    private int pinNo;
    public int HouseNo

    {
        set
        {
            houseNo = value;
        }
        get
        {
            return houseNo;
        }
    }

    public string VillageName

    {
        set
        {
            villageName = value;
        }
        get
        {
            return villageName;
        }
    }

    public int PinNo

    {
        set
        {
            pinNo = value;
        }
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



//..................Employee Class...................

using System;
class Employee
{
    private int empNo;
    private string empName;
    private double empSal;
    private Adress empAdress;

    public int EmpNo
    {
        set
        {
            empNo = value;
        }
        get
        {
            return empNo;
        }
    }

    public string EmpName
    {
        set
        {
            empName = value;
        }
        get
        {
            return empName;
        }
    }

    public double EmpSal
    {
        set
        {
            empSal = value;
        }
        get
        {
            return empSal;
        }
    }

    public Adress EmpAdress
    {
        set
        {
            empAdress = value;
        }
        get
        {
            return empAdress;
        }
    }
}




//.................Has-a Relationship...............
//................Using ( Properties ).............
//.....................Main Method..................

using System;

class Demo
{
    static void Main()
    {
        Console.WriteLine("........Enter Employee Details........");
        Console.WriteLine();

        Console.Write("Enter the Employee No: ");
        int eNo = int.Parse(Console.ReadLine());
        Console.Write("Enter the Employee Name: ");
        string eName = Console.ReadLine();
        Console.Write("Enter the Employee Salery: ");
        double eSal = double.Parse(Console.ReadLine());

        Employee em = new Employee();

        em.EmpNo = eNo;
        em.EmpName = eName;
        em.EmpSal = eSal;

        Console.WriteLine();
        Console.WriteLine("........Enter Adress Details........");
        Console.WriteLine();

        Console.Write("Enter the House No: ");
        int hNo = int.Parse(Console.ReadLine());
        Console.Write("Enter the Village Name: ");
        string vName = Console.ReadLine();
        Console.Write("Enter the Pin No: ");
        int pNo = int.Parse(Console.ReadLine());

        Adress ad = new Adress();

        ad.HouseNo = hNo;
        ad.VillageName = vName;
        ad.PinNo = pNo;


        Console.WriteLine();
        Console.WriteLine("........Show Employee Details........");
        Console.WriteLine();

        Console.WriteLine("Emp No is: " + em.EmpNo);
        Console.WriteLine("Emp Name is: " + em.EmpName);
        Console.WriteLine("Emp Sal is: " + em.EmpSal);

        Console.WriteLine();
        Console.WriteLine("........Show Adress Details........");
        Console.WriteLine();

        Console.WriteLine("Adress is: ");

        Console.WriteLine("House No is: " + ad.HouseNo);
        Console.WriteLine("House Name is: " + ad.VillageName);
        Console.WriteLine("Pin No is: " + ad.PinNo);

        Console.ReadKey();


    }
}