//-----------------------------------------------------------------------
// <copyright file="Distance.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to find the distance from point to origin
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// Distances from origin.
        /// </summary>
        public void DistanceFromOrigin()
        {
            ////initilizing the x coordinate value
            Console.WriteLine("enter x value");
            int x = Utility.GetInt();
            ////initilizing the y  cordinate value
            Console.WriteLine("enter y value");
            int y = Utility.GetInt();
            ////formula to calculate distance from point to origin
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            ////printing the distance from point to origin
            Console.WriteLine("the distance from origin to point is " + distance);
        }
    }
}
