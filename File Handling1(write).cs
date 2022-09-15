
//...............File Handling.............
//.............(Write Operation)...........

using System;
using System.IO;
using System.Text;

class Text
{
    static void Main4545()
    {
        try
        {

            FileStream fs = new FileStream("d:\\demo.text", FileMode.CreateNew);
            Console.WriteLine("Enter the any Data");
            string data = Console.ReadLine();
            byte[] arr = Encoding.ASCII.GetBytes(data);
            for (int i = 0; i < arr.Length; i++)
            {
                fs.WriteByte(arr[i]);
            }
            fs.Close();
            Console.WriteLine("write Data");
        }
        catch (IOException)
        {
            Console.WriteLine("File Already Exist");
        }
        Console.ReadKey();
    }
}

