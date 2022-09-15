


using System;
class Employee
{
    int empNo;
    string empName;
    double empSal;
    public Employee() { }
    public Employee(int empNo,string empName,double empSal)
    {
        this.empNo = empNo;
        this.empName = empName;
        this.empSal = empSal;
    }
    public Employee(Employee empl)
    {
        this.empNo =empl.empNo;
        this.empName =empl.empName;
        this.empSal =empl.empSal;
    }
    public override string ToString()
    {
        return "Emp Id Is: "+empNo + "\n" + "Emp Name Is: "+empName + "\n" + "Emp Selary is: "+empSal;
    }


    class test
    {
        static void Main()
        {
            Employee e1 = new Employee(101, "Manish", 15235.21);
            Console.WriteLine(e1);

            Console.WriteLine();
            Console.WriteLine("...................Print the Copy Construvtoe Variablr.................");
            Console.WriteLine();

            Employee e2 = new Employee(e1);
            Console.WriteLine(e2);
            Console.ReadKey();


        }
    }

}

