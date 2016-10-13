/* Write a program that reads your birthday(in the format MM.DD.YYYY)
 *  from the console and prints on the console how old you are you now and how old will you be after 10 years.
 *  */

using System;
using System.Globalization;

class Age
{
    static void Main()
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        string formatDate = "MM.dd.yyyy";
        string input = Console.ReadLine();
        DateTime inputDate = DateTime.ParseExact(input, formatDate, provider);
        // DateTime inputDate = DateTime.Parse(Console.ReadLine());
        DateTime correctedNowDate = DateTime.Now.AddMonths(-7);
        int result = 0;
        if (correctedNowDate.Month > inputDate.Month)
        {
            //result = correctedNowDate.Year - inputDate.Year;
            if (correctedNowDate.Date > inputDate.Date)
            {
                result = correctedNowDate.Year - inputDate.Year;
            }
            else if (correctedNowDate.Date <= inputDate.Date)
            {
                result = correctedNowDate.Year - inputDate.Year - 1;
            }
        }
        else if (correctedNowDate.Month == inputDate.Month)
        {
            if (correctedNowDate.Date > inputDate.Date)
            {
                result = correctedNowDate.Year - inputDate.Year;
            }
            else if (correctedNowDate.Date <= inputDate.Date)
            {
                result = correctedNowDate.Year - inputDate.Year - 1;
            }
        }
        else
        {
            result = correctedNowDate.Year - inputDate.Year - 1;
        }
        Console.WriteLine(result);
        Console.WriteLine(result + 10);
    }
}