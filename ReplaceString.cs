//-----------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Fellowship
{
    using System;

    /// <summary>
    /// this class is used to replace a string 
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Replaces the string1.
        /// </summary>
        public void ReplaceString1()
        {
            try
            {
                Console.WriteLine("enter name to replace");
                //// take the string input from user
                string name = Console.ReadLine();
                string message = "Hello <<UserName>>, How are you?";
                string fullMessage = null;
                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("enter proper name");
                }
                else
                {
                    fullMessage = message.Replace("<<UserName>>", name);
                }
                ////it will print the string that is replaced with "<<UserName>>"
                Console.WriteLine(fullMessage);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
