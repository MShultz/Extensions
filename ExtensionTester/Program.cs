using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShultzM_ExtensionMethods;

namespace ExtensionTester
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPrintWithInt();
            TestPrintWithString();
            Console.WriteLine();
            TestToPower();
            Console.WriteLine();
            TestIsPalindrome();
        }

        private static void TestPrintWithInt()
        {
            List<int> testers = new List<int>
            {
                1, 2, 3, 4
            };
            Console.WriteLine("-----Print Method Test Int------");
            Console.WriteLine("Expected: 1, 2, 3, 4");
            testers.Print();
            PrintLineBreak();

        }

        private static void TestPrintWithString()
        {
            List<String> testers = new List<String>
            {
                "Apple", "Banana", "Cucumber", "D-food"
            };
            Console.WriteLine("-----Print Method Test String-----");
            Console.WriteLine("Expected:  Apple, Banana, Cucumber, D-food");
            testers.Print();
        }

        private static void TestToPower()
        {
            Console.WriteLine("-----To Power Test-----");
            Console.WriteLine("Testing 2^2");
            Console.WriteLine("Expected: {0}", 4);
            Console.WriteLine("Tested: {0}", 2.ToPower(2));
            PrintLineBreak();

            Console.WriteLine("Testing 150^3");
            Console.WriteLine("Expected: {0}", 3375000);
            Console.WriteLine("Tested: {0}", 150.ToPower(3));
            PrintLineBreak();

            Console.WriteLine("Testing 2^16");
            Console.WriteLine("Expected: {0}", 65536);
            Console.WriteLine("Tested: {0}", 2.ToPower(16));
        }

        private static void TestIsPalindrome()
        {
            Console.WriteLine("-----Is Palindrome Test-----");

            String testString = "Bob";
            Console.WriteLine("Testing \"{0}\"", testString);
            Console.WriteLine("Expected: {0}", true);
            Console.WriteLine("Tested: {0}", testString.IsPalindrome());
            PrintLineBreak();

            testString = "Taco cat";
            Console.WriteLine("Testing \"{0}\"", testString);
            Console.WriteLine("Expected: {0}", true);
            Console.WriteLine("Tested: {0}", testString.IsPalindrome());
            PrintLineBreak();

            testString = "Taco cat";
            Console.WriteLine("Testing \"{0}\"", testString);
            Console.WriteLine("Expected: {0}", true);
            Console.WriteLine("Tested: {0}", testString.IsPalindrome());
            PrintLineBreak();

            testString = "TAcoCat";
            Console.WriteLine("Testing \"{0}\"", testString);
            Console.WriteLine("Expected: {0}", true);
            Console.WriteLine("Tested: {0}", testString.IsPalindrome());
            PrintLineBreak();

            testString = "raceCar";
            Console.WriteLine("Testing \"{0}\"", testString);
            Console.WriteLine("Expected: {0}", true);
            Console.WriteLine("Tested: {0}", testString.IsPalindrome());

            PrintLineBreak();
            testString = "Cuppycakes";
            Console.WriteLine("Testing \"{0}\"", testString);
            Console.WriteLine("Expected: {0}", false);
            Console.WriteLine("Tested: {0}", testString.IsPalindrome());
        }

        private static void PrintLineBreak()
        {
            Console.WriteLine("-----------------------");
        }
    }
}
