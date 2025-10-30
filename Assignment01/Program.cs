using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region constraints default

            // 1 --> The default constraint in C# specifies that a generic type parameter has no specific restriction (neither class nor struct).

            // 2 --> It is mainly used when overriding methods or explicitly implementing interfaces to match an unconstrained base definition.

            // 3 --> It helps the compiler resolve ambiguity introduced by nullable reference types.

            #endregion

            #region Q1

            //Range<int> r = new Range<int>(7, 21);
            //Console.WriteLine(r.IsInRange(17));
            //Console.WriteLine(r.IsInRange(27));

            //Console.WriteLine( "-------");

            //var range = new Range<int>(7, 21);
            //Console.WriteLine(range.Length());

            #endregion

            #region Q2

            //int[] arr = { 7, 8, 9, 10, 6, 3, 5, 1, 2, 4 };

            //foreach (int i in arr) Console.WriteLine(i);

            //Console.WriteLine("\n");

            //Helper<int>.BubbleSort(arr);

            //foreach (int i in arr) Console.WriteLine(i);


            #endregion

            #region Q3

            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };

            //int[] evens = GetEvenNumber.GetEvenNumbers(num);


            //for (int i = 0; i < evens.Length; i++)
            //{
            //    if (i == 0) Console.Write("Even numbers: ");

            //    Console.Write($"{i} ");
            //}


            #endregion

            #region Q4

            //FixedSizeList<int> num = new FixedSizeList<int> (3);

            //num.Add (7);
            //num.Add (21);
            //num.Add(22);
            //num.Add (23);

            //Console.WriteLine($"Item at index 0: {num.Get(0)}");
            //Console.WriteLine($"Item at index 1: {num.Get(1)}");
            //Console.WriteLine($"Item at index 2: {num.Get(2)}");
            //Console.WriteLine($"Item at index 3: {num.Get(3)}");

            #endregion

            #region Q5

            //string input = "  . Abdo Mahmoud ^ Sonbol ,";

            //char result = FirstUniqueCharFinder.FindFirstNonRepeating(input);

            //if (result != '\0')
            //    Console.WriteLine($"The first non-repeating letter is '{result}'");
            //else
            //    Console.WriteLine("No non-repeating letters found");


            #endregion

        }

    }
}
