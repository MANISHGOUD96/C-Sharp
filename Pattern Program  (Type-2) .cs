
//.........................Type-1........................
/*
   
A
A A
A A A
A A A A
A A A A A
 
*/


using System;
class pattern
{
    static void Main()
    {
        int ctr = 1;
        int ptr;
        while (ctr <= 5)
        {
            ptr = 1;
            while (ptr<=ctr)
            {
                Console.Write("A ");
                ptr++;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}


//.........................Type-2........................
/*

*
* *
* * *
* * * *
* * * * * 
 
*/

/*
using System;
class pattern
{
    static void Main()
    {
        int ctr = 1;
        int ptr;
        while (ctr <= 5)
        {
            ptr = 1;
            while (ptr<=ctr)
            {
                Console.Write("* ");
                ptr++;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}
*/


//.........................Type-3........................
/*
 1
 2 2
 3 3 3
 4 4 4 4
 5 5 5 5 5

*/

/*
using System;
class pattern
{
    static void Main()
    {
        int ctr=1;
        int ptr;
        while (ctr <= 5)
        {
            ptr = 1;
            while(ptr<=ctr)
            {
                Console.Write(" "+ctr);
                ptr++;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}
*/


//.........................Type-4........................
/*
  
 1
 1 2
 1 2 3
 1 2 3 4
 1 2 3 4 5

*/


/*
using System;
class pattern
{
    static void Main()
    {
        int ctr = 1;
        int ptr;
        while (ctr <= 5)
        {
            ptr = 1;
            while (ptr <= ctr)
            {
                Console.Write(" "+ptr);
                ptr++;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}
*/


//.........................Type-5........................
/*
 
 A
 A B
 A B C
 A B C D
 A B C D E

*/

/*
using System;
class pattern
{
    static void Main()
    {
        int ctr = 1;
        int ptr;
        while (ctr <= 5)
        {
            ptr = 1;
            while (ptr<=ctr)
            {
                Console.Write(" "+(char)(ptr+64));
                ptr++;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}
*/

//.........................Type-6........................
/*
 
 A
 B B
 C C C
 D D D D
 E E E E E

*/

/*
using System;
class pattern
{
    static void Main()
    {
        int ctr = 1;
        int ptr;
        while (ctr <= 5)
        {
            ptr = 1;
            while (ptr<=ctr)
            {
                Console.Write(" " + (char)(ctr + 64));
                ptr++;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}
*/


