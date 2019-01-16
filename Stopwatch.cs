//-----------------------------------------------------------------------
// <copyright file="StopwatchForElapsedTime.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// this class is used to find the elapse time
    /// </summary>
    public class StopwatchForElapsedTime
    {
        /// <summary>
        /// Elapsed the time.
        /// </summary>
        public void ElapsedTime()
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                Console.WriteLine("enter 1 to start ");
                ////is used to call start time method
                int i = Utility.GetInt();
                if (i == 1)
                {
                    stopwatch.Start();
                }

                Console.WriteLine("enter 0 to stop ");
                ////is used to call stop time method
                int j = Utility.GetInt();
                if (j == 0)
                {
                    stopwatch.Stop();
                }

                ////printing the elapse time
                Console.WriteLine("elapsed time is " + stopwatch.Elapsed);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 
        }
    }
}
