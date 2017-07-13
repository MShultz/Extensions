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
            Console.WriteLine();
            TestEqualsIgnoreCase();
            Console.WriteLine();
            TestRandom();
            Console.WriteLine();
            TestRandomWithArg();
            Console.WriteLine();
            TestFToC();
            Console.WriteLine();
            TestCToF();
            Console.WriteLine();
            TestIsWithinRange();
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

        private static void TestEqualsIgnoreCase()
        {
            Console.WriteLine("-----Test Equals Ignore Case-----");
            String testString = "Bob";
            String testString2 = "bob";
            Console.WriteLine("Testing \"{0}\" and \"{1}\"", testString, testString2);
            Console.WriteLine("Expected: {0}", true);
            Console.WriteLine("Tested: {0}", testString.EqualsIgnoreCase(testString2));
            PrintLineBreak();

            testString = "Cuppycakes";
            testString2 = "Are not muffins!";
            Console.WriteLine("Testing \"{0}\" and \"{1}\"", testString, testString2);
            Console.WriteLine("Expected: {0}", false);
            Console.WriteLine("Tested: {0}", testString.EqualsIgnoreCase(testString2));
            PrintLineBreak();
        }


        private static void TestRandomWithArg()
        {
            Console.WriteLine("-----Test Random (1 Argument)-----");
            int max = 10;
            int rand;
            for (int i = 0; i < max; ++i)
            {
                rand = max.Random(i);
                Console.WriteLine("--Test {0}--", i);
                Console.WriteLine("Min: {0}, Max: {1}", i, max);
                Console.WriteLine("Generated: {0}", rand);
                Console.WriteLine("Valid Result: {0}", (rand >= i && rand <= max));
            }
        }

        private static void TestRandom()
        {
            Console.WriteLine("-----Test Random-----");
            int rand;
            for (int i = 0; i < 10; ++i)
            {
                rand = i.Random();
                Console.WriteLine("--Test {0}--", i);
                Console.WriteLine("Min: {0}, Max: {1}", 0, i);
                Console.WriteLine("Generated: {0}", rand);
                Console.WriteLine("Valid Result: {0}", (rand >= 0 && rand <= i));
            }

        }

        private static void TestFToC()
        {
            Console.WriteLine("-----Fahrenheit to Celsius Test-----");

            double f = 32;
            double c;
            Console.WriteLine("F: {0}", f);
            c = f.FahrenheitToCelsius();
            Console.WriteLine("Conversion: {0}", c);
            Console.WriteLine("Valid Resuls: {0}", c == 0);

            PrintLineBreak();

            f = 86.9;
            Console.WriteLine("F: {0}", f);
            c = f.FahrenheitToCelsius();
            Console.WriteLine("Conversion: {0}", c);
            Console.WriteLine("Valid Resuls: {0}", c >= 30.5);

            PrintLineBreak();

            f = 50;
            Console.WriteLine("F: {0}", f);
            c = f.FahrenheitToCelsius();
            Console.WriteLine("Conversion: {0}", c);
            Console.WriteLine("Valid Resuls: {0}", c == 10);
        }

        private static void TestCToF()
        {
            Console.WriteLine("-----Celsius to Fahrenheit Test-----");

            double f;
            double c = 0;
            Console.WriteLine("C: {0}", c);
            f = c.CelsiusToFahrenheit();
            Console.WriteLine("Conversion: {0}", f);
            Console.WriteLine("Valid Resuls: {0}", f == 32);

            PrintLineBreak();

            
            c = 30.5;
            Console.WriteLine("C: {0}", c);
            f = c.CelsiusToFahrenheit();
            Console.WriteLine("Conversion: {0}", f);
            Console.WriteLine("Valid Resuls: {0}", f == 86.9);

            PrintLineBreak();

            c = 10;
            Console.WriteLine("C: {0}", c);
            f = c.CelsiusToFahrenheit();
            Console.WriteLine("Conversion: {0}", f);
            Console.WriteLine("Valid Resuls: {0}", f == 50);
        }

        private static void TestIsWithinRange()
        {
            Console.WriteLine("-----Test Test Is Within Range (Double)-----");
            double d1 = 10.056;
            double min = 0.05;
            double max = 16.50;
            Console.WriteLine("Double to test: {0}, Min: {1}, Max: {2}", d1, min, max);
            Console.WriteLine("Expected output: {0}", true);
            Console.WriteLine("IsWithinRange: {0}", d1.IsWithinRange(min, max));
           
            PrintLineBreak();

            d1 = 10.05;
            min = 0.05;
            max = 10.049;
            Console.WriteLine("Double to test: {0}, Min: {1}, Max: {2}", d1, min, max);
            Console.WriteLine("Expected output: {0}", false);
            Console.WriteLine("IsWithinRange: {0}", d1.IsWithinRange(min, max));

            PrintLineBreak();

            Console.WriteLine("-----Test Test Is Within Range (Decimal)-----");
            decimal dec1 = 10.000056M;
            decimal minimum = 0.00005M;
            decimal maximum = 16.50M;
            Console.WriteLine("Double to test: {0}, Min: {1}, Max: {2}", dec1, minimum, maximum);
            Console.WriteLine("Expected output: {0}", true);
            Console.WriteLine("IsWithinRange: {0}", dec1.IsWithinRange(minimum, maximum));

            PrintLineBreak();

            dec1 = 0.000049M;
            minimum = 0.00005M;
            maximum = 16.50M;
            Console.WriteLine("Double to test: {0}, Min: {1}, Max: {2}", dec1, minimum, maximum);
            Console.WriteLine("Expected output: {0}", false);
            Console.WriteLine("IsWithinRange: {0}", dec1.IsWithinRange(minimum, maximum));

            PrintLineBreak();

            Console.WriteLine("-----Test Test Is Within Range (int)-----");
            int num = 8;
            int iminimum = 0;
            int imaximum = 15;
            Console.WriteLine("Double to test: {0}, Min: {1}, Max: {2}", num, iminimum, imaximum);
            Console.WriteLine("Expected output: {0}", true);
            Console.WriteLine("IsWithinRange: {0}", num.IsWithinRange(iminimum, imaximum));

            PrintLineBreak();

            num = -16;
            iminimum = 0;
            imaximum = 15;
            Console.WriteLine("Double to test: {0}, Min: {1}, Max: {2}", num, iminimum, imaximum);
            Console.WriteLine("Expected output: {0}", false);
            Console.WriteLine("IsWithinRange: {0}", num.IsWithinRange(iminimum, imaximum));

            PrintLineBreak();
        }




        private static void PrintLineBreak()
        {
            Console.WriteLine("-----------------------");
        }
    }
}
