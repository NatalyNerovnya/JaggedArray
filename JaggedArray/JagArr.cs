using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    public class JagArr
    {
        
        #region Sorting according to the sum
        public static void SortSum(int[][] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Sum() < arr[j].Sum())
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
        }
        #endregion

        #region Sorting according to the max element in the row
        public static void SortMax(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Max() < arr[j].Max())
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
        }
        #endregion

        #region Sorting according to the min element in the row
        public static void SortMin(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Min() < arr[j].Min())
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
        }
        #endregion

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}
