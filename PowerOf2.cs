//-----------------------------------------------------------------------
// <copyright file="PowerOf2.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to find the powers of 2
    /// </summary>
    public class PowerOf2
    {
        /// <summary>
        /// this is used taking the used input and calculating the power of 2
        /// </summary>
        public void PowersOf2()
        {
            Console.WriteLine("enter powers of 2");
            int power = Convert.ToInt32(Console.ReadLine());
            ////if condition is used to check whether the given number is greater than 0
            if (power >= 0)
            {
                ////this for loop is used for calculating the powers of 2 fromo 0 to the entered power value
                for (int i = 0; i <= power; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("enter the power greater than are equal to 0");
            }

            Console.ReadLine();
        }
    }
}
