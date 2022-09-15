
//.............File Handling...............
//.............Stream Writer...............


using System;
using System.IO;
using System.Text;

class Demo
{
    static void Main1321()
    {
        FileStream fs = new FileStream("d:\\Demo.text", FileMode.Append);
        StreamWriter sw = new StreamWriter(fs);
        Console.WriteLine("Enter the arr Data");
        string data = Console.ReadLine();
        sw.Write(data);
        sw.Close();
        fs.Close();
        Console.WriteLine("Save Data");
    }
}