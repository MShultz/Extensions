using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShultzM_ExtensionMethods
{
    public static class Extensions
    {
        /// <summary>
        /// Prints out the objects, separating each value with a comma (,) while making sure there is NO dangling tail symbol.
        /// </summary>
        /// <typeparam name="T">The element type of the collection</typeparam>
        /// <param name="items">A collection of objects</param>
        public static void Print<T>(this IEnumerable<T> items)
        {
            String printable = "";
            foreach (T item in items)
            {
                printable += item.ToString() + ", ";
            }
            Console.WriteLine(printable.TrimEnd(' ').TrimEnd(','));
        }

        /// <summary>
        /// Performs a power calculation on the provided int
        /// </summary>
        /// <param name="baseNum"></param>
        /// <param name="exponent"></param>
        /// <returns>The calculated </returns>
        public static long ToPower(this int baseNum, int exponent)
        {
            return (long)Math.Pow((double)baseNum, (double)exponent);
        }

        /// <summary>
        /// Returns a bool signifying whether the string is a palindrome (reads backward the same as forward), ignoring both casing and any whitespace.
        /// </summary>
        /// <param name="testingString">String to be tested</param>
        /// <returns>A bool signifying whether the string is a palindrome</returns>
        public static bool IsPalindrome(this String testingString)
        {
            String tester = testingString.Replace(" ", "").ToLower();
            return tester.SequenceEqual(tester.Reverse());

        }

        /// <summary>
        /// Determines whether two string equal one another, no matter the case.
        /// </summary>
        /// <param name="initialString">The string to be tested against</param>
        /// <param name="testingString">The string to test</param>
        /// <returns>A bool indicating whether the two strings are equal or not</returns>
        public static bool EqualsIgnoreCase(this string initialString, string testingString)
        {
            return initialString.Equals(testingString, StringComparison.InvariantCultureIgnoreCase);
        }

        private static readonly Random rand = new Random();
        /// <summary>
        /// Returns a random integer between the values provided.
        /// </summary>
        /// <param name="maximum">The maximum boundary (inclusive) </param>
        /// <param name="minimum">The minimum boundary (inclusive)</param>
        /// <returns>Returns a pseudo-random integer inbetween the minimum and maximum values (inclusive).</returns>
        public static int Random(this int maximum, int minimum)
        {
            return rand.Next(minimum, maximum + 1);
        }

        /// <summary>
        /// Returns a random integer between 0 and the value called upon.
        /// </summary>
        /// <param name="maximum">The maximum boundary (inclusive)</param>
        /// <returns>Returns a pseudo-random integer from 0 and the maximum value (inclusive).</returns>
        public static int Random(this int maximum)
        {
            return rand.Next(maximum + 1);
        }

        /// <summary>
        /// Converts a given Fahrenheit value to its Celsius equivalent.
        /// </summary>
        /// <param name="fahrenheitAmount">The value in Fahrenheit</param>
        /// <returns>The converted Celsius value</returns>
        public static double FahrenheitToCelsius(this double fahrenheitAmount)
        {
            return (((fahrenheitAmount - 32) * 5) / 9);
        }

        /// <summary>
        /// Converts a given Celsius value to its Fahrenheit equivalent.
        /// </summary>
        /// <param name="celsiusAmount">The value in Celsius</param>
        /// <returns>The converted Fahrenheit value</returns>
        public static double CelsiusToFahrenheit(this double celsiusAmount)
        {
            return (((celsiusAmount * 9) / 5) + 32);
        }

        /// <summary>
        /// Determines whether a specific value (double) is within range of an upper and lower bound.
        /// </summary>
        /// <param name="value">The double value to be checked</param>
        /// <param name="lowerBound">The double lower boundary (inclusive)</param>
        /// <param name="upperBound">The double upper boundary (inclusive)</param>
        /// <returns>A bool representing the outcome of the range check</returns>
        public static bool IsWithinRange(this double value, double lowerBound, double upperBound)
        {

            return (value >= lowerBound && value <= upperBound);
        }

        /// <summary>
        /// Determines whether a specific value (decimal) is within range of an upper and lower bound.
        /// </summary>
        /// <param name="value">The decimal value to be checked</param>
        /// <param name="lowerBound">The decimal lower boundary (inclusive)</param>
        /// <param name="upperBound">The decimal upper boundary (inclusive)</param>
        /// <returns>A bool representing the outcome of the range check</returns>
        public static bool IsWithinRange(this decimal value, decimal lowerBound, decimal upperBound)
        {
            return (value >= lowerBound && value <= upperBound);
        }

        /// <summary>
        /// Determines whether a specific value (int) is within range of an upper and lower bound.
        /// While IsWithinRange(double) will perform the same task to the same efficiency, this removes the need for casting.
        /// </summary>
        /// <param name="value">The int value to be checked</param>
        /// <param name="lowerBound">The int lower boundary (inclusive)</param>
        /// <param name="upperBound">The int upper boundary (inclusive)</param>
        /// <returns>A bool representing the outcome of the range check</returns>
        public static bool IsWithinRange(this int value, int lowerBound, int upperBound)
        {

            return (value >= lowerBound && value <= upperBound);
        }

    }
}
