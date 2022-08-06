class demo{
    static void Main(){
        System.Console.Write("Enter the size of arr: ");
        int size=int.Parse(System.Console.ReadLine());
        char []arr=new char[size];
        for(char i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter the arr Value: ");
            arr[i]=System.Convert.ToChar(System.Console.ReadLine());
        }
        char ch=arr[i];
        int count=0;
        for(char i=0;i<arr.Length;i++)
        {
            if(ch=='A'|| ch=='E'|| ch=='I'|| ch=='O'|| ch=='U'|| ch=='a'|| ch=='e'|| ch=='i'|| ch=='o'|| ch=='u')
             count++;
            else
            count++;
        }
    }
}