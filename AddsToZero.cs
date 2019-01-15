﻿//-----------------------------------------------------------------------
// <copyright file="AddsToZero.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to add the three numbers in array 
    /// </summary>
    public class AddsToZero
    {
        /// <summary>
        /// Add3s the numbers to zero.
        /// </summary>
        public void Add3NumbersToZero()
        {
            Console.WriteLine("enter the number of elements");
            int n = Utility.GetInt();
            int[] array = new int[n];
            ////taking the array elements from console
            Console.WriteLine("enter array elements");
            ////this loop is used for storing the array elements
            for (int index = 0; index < n; index++)
            {
                array[index] = Utility.GetInt();
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for (int k = 0; k < n - 2; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            sum++;
                            Console.WriteLine(" distinct   triplets " + array[i] + "," + array[j] + "," + array[k]);
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("number of distinct triplets " + sum);
            Console.ReadLine();
        }
    }
}