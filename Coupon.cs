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
            Console.WriteLine("enter size N Distinct Coupon Number");
            int n = Utility.GetInt();
            int count = 0;
            Random random = new Random();
            string distinctCouponNumber = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string value = random.Next(0, n) + string.Empty;
                count++;
                if (!distinctCouponNumber.Contains(value))
                {
                    distinctCouponNumber = distinctCouponNumber + value;
                }
                else
                {
                    i--;
                }
            }

            Console.WriteLine("random number needed to have all distinct numbers is " + count);
            Console.WriteLine("distinctCouponNumbers is ");
            foreach (char numbers in distinctCouponNumber)
            {
                Console.WriteLine(numbers);
            }

            Console.ReadLine();
        }
    }
}
