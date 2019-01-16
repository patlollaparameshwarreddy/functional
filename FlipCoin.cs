//-----------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to find number of heads and tails
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// Flips this instance.
        /// </summary>
        public void Flip()
        {
            try
            {
                ////taking number of times to flip a coin
                Console.WriteLine("enter number of times to flip");
                int times = Convert.ToInt32(Console.ReadLine());
                Random rd = new Random();
                int heads = 0;
                int tails = 0;
                if (times > 0)
                {
                    //// for loop to get random number
                    for (int i = 1; i <= times; i++)
                    {
                        int value = rd.Next(1, 3);
                        if (value < 1.5)
                        {
                            tails++;
                        }
                        else
                        {
                            heads++;
                        }
                    }

                    Console.WriteLine(heads);
                    Console.WriteLine(tails);
                    Console.WriteLine("tails percentage is " + ((tails * 100) / times));
                    Console.WriteLine("heads percentage is " + ((heads * 100) / times));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("enter number greater than 0");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
