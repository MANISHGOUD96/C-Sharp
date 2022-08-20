
//.........................Type-1........................
/*
   
 A A A A A
 A A A A A
 A A A A A
 A A A A A
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
            while (ptr<=5)
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
 
 * * * * *
 * * * * *
 * * * * *
 * * * * *
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
            while (ptr<=5)
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
  1 1 1 1 1
  2 2 2 2 2
  3 3 3 3 3
  4 4 4 4 4
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
            while(ptr<=5)
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
  
 1 2 3 4 5
 1 2 3 4 5
 1 2 3 4 5
 1 2 3 4 5
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
            while (ptr <= 5)
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
 
 A B C D E
 A B C D E
 A B C D E
 A B C D E
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
            while (ptr<=5)
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
 
 A B C D E
 A B C D E
 A B C D E
 A B C D E
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
            while (ptr<=5)
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


