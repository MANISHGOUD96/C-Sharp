
//.............File Handling...............
//.............Binary Write...............


using System;
using System.IO;
using System.Text;

class dix
{
    static void Main125()
    {
        BinaryWriter bw = new BinaryWriter(new FileStream("d:\\Demo.txt", FileMode.Create));
        Console.Write("Enter the no: ");
        int no = int.Parse(Console.ReadLine());
        Console.Write("Enter The Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the Age: ");
        float age = float.Parse(Console.ReadLine());
        Console.Write("Enter the Boolean Value: ");
        bool va= bool.Parse(Console.ReadLine());

        bw.Write(no);
        bw.Write(name);
        bw.Write(age);
        bw.Write(va);
        bw.Close();
        Console.WriteLine("Save");
    }
}