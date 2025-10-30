using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal static class Helper<Ty> where Ty : IEquatable<Ty>, IComparable<Ty>
    {

        #region Swaping

        public static void Swap(ref Ty x, ref Ty y)
        {
            Ty temp = x;
            x = y;
            y = temp;
        }

        #endregion

        #region BubbleSort Q2

        public static void BubbleSort(Ty[] arr)
        {
            if (arr == null) return;

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) < 0)
                        Swap(ref arr[j], ref arr[j + 1]);

                }
            }

            return;

        }

        public static void BubbleSort(Ty[] arr, IComparer<Ty> comparer)
        {
            if (arr == null) return;

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (comparer.Compare(arr[j], arr[j + 1]) < 0)
                        Helper<Ty>.Swap(ref arr[j], ref arr[j + 1]);

                }
            }

            return;

        }


        #endregion

        #region linearSearch 

        public static int linearSearch(Ty[]? Arr, Ty value)
        {
            if (Arr is not null && Arr.Length > 0)
            {
                for (int i = 0; i < Arr.Length; ++i)
                {
                    if (Arr[i]?.Equals(value) ?? false) return i;
                }
            }
            return -1;
        }

        public static int linearSearch(Ty[]? Arr, Ty value, IEqualityComparer<Ty> comparer)
        {
            if (Arr is not null && Arr.Length > 0 && value is not null)
            {
                for (int i = 0; i < Arr.Length; ++i)
                {
                    if (comparer.Equals(Arr[i], value)) return i;
                }
            }
            return -1;
        }



        #endregion





    }
}
