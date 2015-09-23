using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArray;

namespace JaggedArrayTests
{
    [TestClass]
    public class JagArrTests
    {
        [TestMethod]
        public void SortSum_PositiveArray_SortedArrayAccordingToTheSum()
        {
            int row = 3;
            int[][] jagArr = new int[row][];
            jagArr[0] = new int[] { 6, 3, 2 };
            jagArr[1] = new int[] { 3, 5, 2, 0, 6, 1 };
            jagArr[2] = new int[] {6, 3, 4};

            int[][] resultArray = new int[row][];
            resultArray[0] = new int[] { 3, 5, 2, 0, 6, 1 };
            resultArray[1] = new int[] { 6, 3, 4 };
            resultArray[2] = new int[] { 6, 3, 2 };

            JagArr.SortSum(jagArr);

            CollectionAssert.AreEqual(jagArr[0], resultArray[0]);
            CollectionAssert.AreEqual(jagArr[1], resultArray[1]);
            CollectionAssert.AreEqual(jagArr[2], resultArray[2]);
        }

        [TestMethod]
        public void SortSum_NegativeArray_SortedArrayAccordingToTheSum()
        {
            int row = 3;
            int[][] jagArr = new int[row][];
            jagArr[0] = new int[] { -6, -3, -2 };
            jagArr[1] = new int[] { -3, -5, -2, -6, -1 };
            jagArr[2] = new int[] { -6, -3, -4 };
            
            int[][] resultArray = new int[row][];
            resultArray[0] = new int[] { -6, -3, -2 };
            resultArray[1] = new int[] { -6, -3, -4 };
            resultArray[2] = new int[] { -3, -5, -2, -6, -1 };

            JagArr.SortSum(jagArr);

            CollectionAssert.AreEqual(jagArr[0], resultArray[0]);
            CollectionAssert.AreEqual(jagArr[1], resultArray[1]);
            CollectionAssert.AreEqual(jagArr[2], resultArray[2]);
        }

        [TestMethod]
        public void SortSum_DifferentElementsArray_SortedArrayAccordingToTheSum()
        {
            int row = 3;
            int[][] jagArr = new int[row][];
            jagArr[0] = new int[] { -6, 3, -2 };
            jagArr[1] = new int[] { -3, -5, 2, -6, 1 };
            jagArr[2] = new int[] { 6, -3, 4 };

            int[][] resultArray = new int[row][];
            resultArray[0] = new int[] { 6, -3, 4 };//7
            resultArray[1] = new int[] { -6, 3, -2 };//-5
            resultArray[2] = new int[] { -3, -5, 2, -6, 1 };//-11

            JagArr.SortSum(jagArr);

            CollectionAssert.AreEqual(jagArr[0], resultArray[0]);
            CollectionAssert.AreEqual(jagArr[1], resultArray[1]);
            CollectionAssert.AreEqual(jagArr[2], resultArray[2]);
        }

    }
}
