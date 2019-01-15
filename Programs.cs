//-----------------------------------------------------------------------
// <copyright file="Programs.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to run all the programs
    /// </summary>
    public class Programs
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            ////declared condition character
            char condition;
            do
            {
                Console.WriteLine("enter 1 for replace string");
                Console.WriteLine("enter 2 for flipcoin");
                Console.WriteLine("enter 3 for leapyear");
                Console.WriteLine("enter 4 for powers of 2");
                Console.WriteLine("enter 5 for harmonic number");
                Console.WriteLine("enter 6 for prime factors");
                Console.WriteLine("enter 7 for gambler");
                Console.WriteLine("enter 8 for coupon number  ");
                Console.WriteLine("enter 9 for 2d array");
                Console.WriteLine("enter 10 for Sum of three Integer adds to ZERO");
                Console.WriteLine("enter 11 for finding distancre from point to origin");
                Console.WriteLine("enter 12 for finding Quadratic equatiion roots");
                Console.WriteLine("enter 13 for WindChill");
                Console.WriteLine("enter 14 for stop watch");
                Console.WriteLine("enter 15 for permutation of a String");
                Console.WriteLine("enter 16 for tictactoe game");
                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        ReplaceString replace = new ReplaceString();
                        replace.ReplaceString1();
                        break;
                    case 2:
                        FlipCoin flip = new FlipCoin();
                        flip.Flip();
                        break;
                    case 3:
                        LeapYear leapYear = new LeapYear();
                        leapYear.Leapyear();
                        break;
                    case 4:
                        PowerOf2 power = new PowerOf2();
                        power.PowersOf2();
                        break;
                    case 5:
                        HarmonicNumbers harmonic = new HarmonicNumbers();
                        harmonic.Harmonic();
                        break;
                    case 6:
                        PrimeFactors primeFactors = new PrimeFactors();
                        primeFactors.Prime_Factors();
                        break;
                    case 7:
                        Gambler gambler = new Gambler();
                        gambler.Gambler1();
                        break;
                    case 8:
                        Coupon coupon = new Coupon();
                        coupon.CouponNumbers();
                        break;
                    case 9:
                        Array array = new Array();
                        array.Array2D();
                        break;
                    case 10:
                        AddsToZero toZero = new AddsToZero();
                        toZero.Add3NumbersToZero();
                        break;
                    case 11:
                        Distance distance = new Distance();
                        distance.DistanceFromOrigin();
                        break;
                    case 12:
                        Quadratic quadratic = new Quadratic();
                        quadratic.Roots();
                        break;
                    case 13:
                        WindChill windChill = new WindChill();
                        windChill.CalculateWindChill();
                        break;
                    case 14:
                        StopwatchForElapsedTime stopwatch = new StopwatchForElapsedTime();
                        stopwatch.ElapsedTime();
                        break;
                    case 15:
                        Permutations permutations = new Permutations();
                        permutations.StartPermutation();
                        break;
                    case 16:
                        TicTocToe ticTocToe = new TicTocToe();
                        ticTocToe.TicTocToeGame();
                        break;
                }

                Console.WriteLine("enter y to continue enter n to stop ");
                condition = Convert.ToChar(Console.ReadLine());
            }
            while (condition == 'y');
        }
    }
}
