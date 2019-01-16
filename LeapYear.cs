//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to find whether the given year is a leap year or not
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Leap year this instance.
        /// </summary>
        public void Leapyear()
        {
            try
            {
                Console.WriteLine("enter year with four digits");
                string year = Console.ReadLine();
                if (year.Length == 4)
                {
                    int num = Convert.ToInt32(year);
                    if (num % 4 == 0)
                    {
                        Console.WriteLine(num + " is a leap year");
                    }
                    else
                    {
                        Console.WriteLine(num + " is not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("Year should be atleast ");
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
