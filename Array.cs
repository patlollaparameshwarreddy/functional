//-----------------------------------------------------------------------
// <copyright file="Array.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to store array elements 
    /// </summary>
    public class Array
    {
        /// <summary>
        /// Array2s the d.
        /// </summary>
        public void Array2D()
        {
            ////enter the size of row
            Console.WriteLine("enter row value");
            int row = Utility.GetInt();
            ////enter the size of coloumn
            Console.WriteLine("enter column value");
            int column = Utility.GetInt();
            string[,] a = new string[row, column];
            Console.WriteLine("enter array elementa");
            ////this is used for storing array elements 
            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= column - 1; j++)
                {
                    a[i, j] = Console.ReadLine();
                }
            }
            ////this loop is used for displaying array elements
            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= column - 1; j++)
                {
                    Console.Write(a[i, j] + "     ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
