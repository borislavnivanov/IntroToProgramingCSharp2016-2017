/*
 * Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

You might need to learn how to use loops in C# (search in Internet).
*/

using System;


class LongSequence
{
    static void Main()
    {
        for (short i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0}   {1}   {2}", i , i+1 , i);
            
            }
            else
            {
                Console.WriteLine("-{0}", i);
            }
        }
    }
}

