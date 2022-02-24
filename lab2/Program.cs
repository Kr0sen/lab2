using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RomanNumber n1, n2;
            RomanNumber[] array = { new RomanNumber(10),
                new RomanNumber(32323), new RomanNumber(10000),
                new RomanNumber(4521),new RomanNumber(1),
                new RomanNumber(11),new RomanNumber(10)};

            n1 = new RomanNumber(23456);
            n2 = new RomanNumber(5123);

            Console.WriteLine("Unsorted array:");
            foreach (RomanNumber n in array)
            {
                Console.Write("{0} ", n.ToString());
            }
            Array.Sort(array);
            Console.WriteLine("\nSorted array:");
            foreach (RomanNumber n in array)
            {
                Console.Write("{0} ", n.ToString());
            }
            Console.WriteLine("");

            // n1: MMMMMMMMMMMMMMMMMMMMMMMCDLVI
            // n2: MMMMMCXXIII
            Console.WriteLine("n1: {0}\nn2: {1}", (n1).ToString(), (n2).ToString());

            // n1+n2: MMMMMMMMMMMMMMMMMMMMMMMMMMMMDLXXIX
            Console.WriteLine("n1+n2: {0}", (RomanNumber.Add(n1, n2)).ToString());

            // n1-n2: MMMMMMMMMMMMMMMMMMCCCXXXIII
            Console.WriteLine("n1-n2: {0}", (RomanNumber.Sub(n1, n2)).ToString());

            // n1/n2: IV
            Console.WriteLine("n1/n2: {0}", (RomanNumber.Div(n1, n2)).ToString());

            try
            {
                Console.WriteLine("n1*n2: {0}", (RomanNumber.Mul(n1, n2)).ToString());
            }
            catch (RomanNumberException e)
            {
                Console.WriteLine($"Found exception: {e.Message}");
            }
            finally
            {
                n1 = new RomanNumber(2509);
                n2 = new RomanNumber(5);
                // n1*n2: MMMMMMMMMMMMDXLV
                Console.WriteLine("2509*5: {0}", (RomanNumber.Mul(n1, n2)).ToString());
            }
        }
    }
}