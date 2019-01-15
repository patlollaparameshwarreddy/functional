﻿//-----------------------------------------------------------------------
// <copyright file="Gambler.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to find wins percentage 
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// Gambler1s this instance.
        /// </summary>
        public void Gambler1()
        {
            ////original amount with the gambler
            Console.WriteLine("enter stake");
            int stake = Utility.GetInt();
            ////the money want to earn
            Console.WriteLine("enter goal");
            int goal = Utility.GetInt();
            ////give value in number of times to resch goal
            Console.WriteLine("enter number of times");
            int times = Utility.GetInt();
            int wins = 0;
            int loss = 0;
            //// creating object of random function
            Random random = new Random();
            for (int i = 0; i < times; i++)
            {
                int cash = stake;
                while (cash > 0 && cash < goal)
                {
                    if (random.Next(0, 2) < 0.5)
                    {
                        cash++;
                    }
                    else
                    {
                        cash--;
                    }
                }

                if (cash == goal)
                {
                    wins++;
                }
                else
                {
                    loss++;
                }
            }
          
           Console.WriteLine(wins + " wins of " + times);
            Console.WriteLine(" percentage of wins is " + ((100.0 * wins) / times));
            Console.WriteLine(" percentage of wins is " + ((100.0 * loss) / times));
            Console.ReadLine();
        }
    }
}