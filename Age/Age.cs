/* Write a program that reads your birthday(in the format MM.DD.YYYY)
 *  from the console and prints on the console how old you are you now and how old will you be after 10 years.
 *  */

using System;

class Age
{
    static void Main()
    {
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        int result = DateTime.Now.Year - inputDate.Year;
        Console.WriteLine("{0}", result);
        Console.WriteLine("{0}", result + 10);
    }
}