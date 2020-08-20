using System;

namespace Kata1
{
    public class YearsRelated
    {
        public static void Step9()
        {
            int currentYear = DateTime.Now.Year;
            int firstLeapYear = DateTime.IsLeapYear(currentYear) ? (currentYear + 4) : (currentYear + 4 - currentYear % 4);
            int[] twentyLeapYears = new int[20];
            for(int i = 0; i <= 19; i++)
            {
                twentyLeapYears[i] = (firstLeapYear + (4 * i));
            }
            Console.WriteLine(String.Join(", ", twentyLeapYears));
        }
    }
}
