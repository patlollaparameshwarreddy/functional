//-----------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used for finding quadratic equation roots
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// Roots this instance.
        /// </summary>
        public void Roots()
        {
            try
            {
                ////taking the value of a from console
                Console.WriteLine("enter a value");
                double a = Utility.GetDouble();
                ////taking the value of b from console
                Console.WriteLine("enter b value");
                double b = Utility.GetDouble();
                ////taking the value of c from console
                Console.WriteLine("enter c value");
                double c = Utility.GetDouble();
                ////formula to calculate b*b - 4*a*c
                double delta = Math.Pow(b, 2) - (4 * a * c);
                ////formula to calculate first root i.e (-b+sqrt(b*b-4ac))/4a
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                ////formula to calculate second root i.e (-b-sqrt(b*b-4ac))/4a
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                ////printing first root of equation
                Console.WriteLine("the first root of equation is " + root1);
                ////printing second root of equation
                Console.WriteLine("the second root of equation is " + root2);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
