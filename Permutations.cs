//-----------------------------------------------------------------------
// <copyright file="Permutations.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to find the permutations of a given string
    /// </summary>
    public class Permutations
    {
        /// <summary>
        /// Starts the permutation.
        /// </summary>
        public void StartPermutation()
        {
            Console.WriteLine("enter string ");
            string s = Console.ReadLine();
            Permutation(s.ToCharArray(), 0);
            Console.ReadLine();
        }

        /// <summary>
        /// Swaps the specified character
        /// </summary>
        /// <param name="words">The character.</param>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        private static void Swap(char[] words, int i, int j)
        {
            char temp = words[i];
            words[i] = words[j];
            words[j] = temp;
        }

        // Recursive function to generate all permutations of a String  
        
        /// <summary>
        /// Permutation the specified character
        /// </summary>
        /// <param name="words">The character </param>
        /// <param name="currentIndex">Index of the current.</param>
        private static void Permutation(char[] words, int currentIndex)
        {
            try
            {
                if (currentIndex == words.Length - 1)
                {
                    string values = new string(words);
                    Console.WriteLine(values);
                }

                for (int i = currentIndex; i < words.Length; i++)
                {
                    Swap(words, currentIndex, i);
                    Permutation(words, currentIndex + 1);
                    Swap(words, currentIndex, i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
