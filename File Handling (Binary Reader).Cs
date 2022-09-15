
//.............File Handling...............
//.............Binary Reader...............

using System;
using System.IO;
using System.Text;

class mix
{
    static void Main()
    {
        BinaryReader br = new BinaryReader(new FileStream("d:\\Demo.txt", FileMode.Open));
        int no = br.ReadInt32();
        string name = br.ReadString();
        float age = br.ReadSingle();
        bool va = br.ReadBoolean();

        Console.WriteLine("No is: " + no);
        Console.WriteLine("Name is: " + name);
        Console.WriteLine("Age is: " + age);
        Console.WriteLine("Boolean is: " + va);
        br.Close();

    }
}