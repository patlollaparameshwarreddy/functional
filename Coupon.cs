//-----------------------------------------------------------------------
// <copyright file="Coupon.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used for generate distinct coupon numbers and number of distinct 
    /// </summary>
    public class Coupon
    {
        /// <summary>
        /// Coupons the numbers.
        /// </summary>
        public void CouponNumbers()
        {
            try
            {
                Console.WriteLine("enter size N Distinct Coupon Number");
                ////this variable is used to store the length of coupon number
                int length = Utility.GetInt();
                ////this string is used to store the resultant distinct coupon numbers
                string distinctCouponNumber = string.Empty;
                int count = 0;
                ////this condition is used to whether the length is correct or not
                if (length > 0)
                {
                    ////creating the object of random class
                    Random random = new Random();
                    ////this loop is used to generate the distinct coupon numbers
                    for (int i = 1; i <= length; i++)
                    {
                        string value = random.Next(0, length) + string.Empty;
                        count++;
                        ////this condition is used to check whether the numbers are repeating or not
                        if (!distinctCouponNumber.Contains(value))
                        {
                            distinctCouponNumber = distinctCouponNumber + value;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("enter proper row and column");
                }

                Console.WriteLine("random number needed to have all distinct numbers is " + count);
                Console.WriteLine("distinctCouponNumbers is ");
                ////this loop is used for printing the distinct coupoun numbers
                foreach (char numbers in distinctCouponNumber)
                {
                    Console.WriteLine(numbers);
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
