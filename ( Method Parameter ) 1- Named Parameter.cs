
//..............Following Types of Method Parameter in C#..........

//.............. 1-Named Parameter................

using System;
class demo
{
    static void Display(int empNo, string empName,double empSal)
    {
        Console.WriteLine(empNo);
        Console.WriteLine(empName);
        Console.WriteLine(empSal);
    }
    static void Main()
    { 
           Display(empName: "Manish", empSal: 55000.52, empNo: 102); // Named Parameter.

       //  Display(102, empName: "Manish", empSal: 55000.52);   // We use actual value before Named Parameter.

       //  Display(empSal:100045.55,empName:"Satish",101);  // We not use actual value after Named Parameter. 

        Console.ReadKey();
    }
}