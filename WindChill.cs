//-----------------------------------------------------------------------
// <copyright file="WindChill.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class will calculate the wind chill
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// Calculates the wind chill.
        /// </summary>
        public void CalculateWindChill()
        {
            ////take the value of temperature from console k
            Console.WriteLine("enter temperature t in Fahrenheit");
            double t = Utility.GetDouble();
            ////taking the value of seep from console
            Console.WriteLine("enter speed v in miles per hour");
            double v = Utility.GetDouble();
            ////formula to calculate the wind chill
            double windChill = 35.74 + (0.6215 * t) + ((0.4275 * t) - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("WindChill is " + windChill);
            Console.ReadLine();
        }
    }
}