using ReverseString;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Apps.ReverseString
{
    /// <summary>
    /// A test console for the reverse string algorithm.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <remarks>The program should run without the asserts breaking execution. Check the output window to confirm.</remarks>
        public static void Main(string[] args)
        {
            var inputString = "$AB!CDE#";
            var validOutput = "$ED!CBA#";
            var reverseStringResult = ReverseString(inputString);
            Debug.Assert(reverseStringResult == validOutput, $"The output '{reverseStringResult}' does not match '{validOutput}'");

            inputString = "&NS ALK.";
            validOutput = "&KL ASN.";
            reverseStringResult = ReverseString(inputString);
            Debug.Assert(reverseStringResult == validOutput, $"The output '{reverseStringResult}' does not match '{validOutput}'");

            inputString = "BNRG1MNIO+ZP";
            validOutput = "PZOI1NMGR+NB";
            reverseStringResult = ReverseString(inputString);
            Debug.Assert(reverseStringResult == validOutput, $"The output '{reverseStringResult}' does not match '{validOutput}'");

            var repeatsArray = new[] { 1000, 10000, 100000, 1000000 };

            foreach (var repeatCount in repeatsArray)
            {
                var inputStringAs = new string('A', repeatCount);
                var inputStringZs = new string('Z', repeatCount);
                var inputStringExclaims = new string('!', repeatCount);

                inputString = $"{inputStringAs}{inputStringExclaims}{inputStringZs}";
                validOutput = $"{inputStringZs}{inputStringExclaims}{inputStringAs}";

                reverseStringResult = ReverseString(inputString);
                Debug.Assert(reverseStringResult == validOutput, $"The output does not match the required result.");
            }

            Console.WriteLine("Press ENTER to Exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Reverses the alphabetic characters in the input string while keeping all special and numeric characters in the same order they were found.
        /// </summary>
        /// <param name="inputString">The input string.</param>
        /// <returns>The input <see cref="string"/> with only alphabetic characters (A to Z and a to z) reversed.</returns>
        private static string ReverseString(string inputString)
        {
            StringManupulation stringManupulation = new StringManupulation();
            return stringManupulation.ReverseString(inputString);
        }
    }
}
