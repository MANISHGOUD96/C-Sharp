
//...............File Handling.............
//.............(Write Operation)...........

using System;
using System.IO;
using System.Text;

class Test
{
    static void Mainbnkasbf()
    {
        try
        {
            FileStream fs = new FileStream("d:\\demo.text", FileMode.Open);
            int data = fs.ReadByte();

            while (data !=-1)
            {
                Console.Write((char)data);
                data = fs.ReadByte();
            }
            fs.Close();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File.Not exixt...........");
        }
        Console.ReadKey();
    }
}
