using System;
class employee
{
     int empNo;
    public void setEmpNo(int empNo)
    {
        this.empNo = empNo;
    }
    public int  getEmpNo()
    {
        return this.empNo;
    }
    class chetu
    {
        static void Main()
        {
            employee e = new employee();
            e.setEmpNo(500);
            Console.WriteLine(e.getEmpNo());
            Console.ReadLine();
        }
    }

}
