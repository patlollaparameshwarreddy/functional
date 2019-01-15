//-----------------------------------------------------------------------
// <copyright file="HarmonicNumbers.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to generate harmonic numbers
    /// </summary>
    public class HarmonicNumbers
    {
        /// <summary>
        /// Harmonics this instance.
        /// </summary>
        public void Harmonic()
        {
            Console.WriteLine("enter to find n th harmonic number");
            int n = Utility.GetInt();
            float result = 0;
            for (int i = 1; i <= n; i++)
            {
                result = result + (float)(1.0 / i);
            }

            Console.WriteLine("n th harmonic number is " + result);
            Console.ReadLine();
        }
    }
}
