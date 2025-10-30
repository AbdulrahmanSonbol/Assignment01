using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class GetEvenNumber
    {
        public static int[] GetEvenNumbers(int[]? arr)
        {
            if (arr == null || arr.Length < 0)
                return Array.Empty<int>();
            

            int count = 0,
                index = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    count++;
            }

            int[] evenNumbers = new int[count];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenNumbers[index] = arr[i];
                    index++;
                }
            }

            return evenNumbers;
        }

    }
}
