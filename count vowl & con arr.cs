class demo{
    static void Main(){
        System.Console.Write("Enter the size of arr: ");
        int size=int.Parse(System.Console.ReadLine());
        char []arr=new char[size];
        int i=0;
        while(i<arr.Length)
        {
            System.Console.Write("Enter the arr Value: ");
            arr[i]=System.Convert.ToChar(System.Console.ReadLine());
            i++;
        }
        int countcon=0,countvow=0;
        i=0;
        while(i<arr.Length)
        {
            if(arr[i]=='A'|| arr[i]=='E'|| arr[i]=='I'|| arr[i]=='O'|| arr[i]=='U'|| arr[i]=='a'|| arr[i]=='e'|| arr[i]=='i'|| arr[i]=='o'|| arr[i]=='u')
             countvow++;
             else
             countcon++;
             i++;
        }
             System.Console.WriteLine("Total Vowel: "+countvow);
             System.Console.WriteLine("Total Consonent: "+countcon);
    }
}