
//.............File Handling...............
//.............Stream Reader...............


using System;
using System.IO;
using System.Text;

class str 
{
    static void Main12354()
    {
        FileStream fs = new FileStream("d:\\Demo.text", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        String data = sr.ReadLine();
        while(data != null)
        {
            Console.WriteLine(data);
            data = sr.ReadLine();
        }
        sr.Close();
        fs.Close();
    }
}