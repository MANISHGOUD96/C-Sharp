class demo{
    static void Main(){
        System.Console.Write("Enter the size of arry: ");
        int size=int.Parse(System.Console.ReadLine());
        int []arr=new int[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter the value: ");
            arr[i]=int.Parse(System.Console.ReadLine());
        }
        
        System.Console.WriteLine(".........................");
         
         
        for(int i=0;i<arr.Length;i++)
        {  
            int count=0,prim=0;
            int c=arr[i];
            for(int j=1;j<=c;j++)
            {
            if(c%j==0)
                prim++;
               count++;
            
             }   
             if(count==2)
             {
              System.Console.WriteLine("Prime Number is: "+prim);
              
             }
            
             
        }
    }
}