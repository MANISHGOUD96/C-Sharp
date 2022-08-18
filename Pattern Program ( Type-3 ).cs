
//.........................Type-1........................
/*
   
 A A A A A
 A A A A
 A A A
 A A
 A
 
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
            ptr = 5;
            while (ptr >= ctr)
            {
                Console.Write("A ");
                ptr--;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}


//.........................Type-2........................
/*
 
 * * * * *
 * * * *  
 * * * 
 * * 
 * 
 
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
            ptr = 5;
            while (ptr >= ctr)
            {
                Console.Write("* ");
                ptr--;
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
 2 2 2 2
 3 3 3
 4 4
 5
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
            ptr = 5;
            while(ptr>=ctr)
            {
                Console.Write(" "+ctr);
                ptr--;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}
*/

//.........................Type-4........................
/*
 1 1 1 1 1
 2 2 2 2
 3 3 3
 4 4
 5
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
            ptr = 5;
            while (ptr >= ctr)
            {
                Console.Write(" "+ptr);
                ptr--;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}
*/

//.........................Type-5........................
/*
 E D C B A
 E D C B
 E D C
 E D
 E
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
            ptr = 5;
            while (ptr >= ctr)
            {
                Console.Write(" "+(char)(ptr+64));
                ptr--;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}
*/

//.........................Type-6........................
/*
 A A A A A
 B B B B
 C C C
 D D
 E
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
            ptr = 5;
            while (ptr >= ctr)
            {
                Console.Write(" " + (char)(ctr + 64));
                ptr--;
            }
            Console.WriteLine();
            ctr++;
        }
    }
}
*/


