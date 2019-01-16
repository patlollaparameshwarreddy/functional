//-----------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to find prime factors of a given number
    /// </summary>
    public class PrimeFactors
    {
        /// <summary>
        /// Primes the factors.
        /// </summary>
        public void Prime_Factors()
        {
            try
            {
                Console.WriteLine("enter number to find prime factors");
                int number = Utility.GetInt();
                for (int i = 1; i <= number; i++)
                {
                    int count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }

                    if (count == 2)
                    {
                        int validation = 1;
                        while (number % i == 0)
                        {
                            if (validation == 1)
                            {
                                Console.WriteLine(i);
                                validation++;
                            }

                            number = number / i;
                        }
                    }
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
