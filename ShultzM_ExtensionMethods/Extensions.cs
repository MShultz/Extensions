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
            foreach(T item in items){
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
            return (long) Math.Pow((double)baseNum, (double)exponent);
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
        public static int Random(this int maximum, int minimum)
        {
            return rand.Next(minimum, maximum + 1);
        }

        public static int Random(this int maximum)
        {
            return rand.Next(maximum + 1);
        }
    }
}
