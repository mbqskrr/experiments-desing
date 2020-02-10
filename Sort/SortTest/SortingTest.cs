using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;

namespace SortTest
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void BubbleTest()
        {
            int[] arr = { 20, 1, 30, 80, 8 };
            Sorting.SetArr(arr);
            Sorting.Bubble();
            Assert.AreEqual(1, arr[0]);
            Assert.IsTrue(arr[0] < arr[1]);
            Assert.IsTrue(arr[arr.Length-1] > arr[0]);
            Assert.IsFalse(arr[arr.Length - 2] > arr[arr.Length-1]);
        }

        [TestMethod]
        public void SelectionSort() 
        {
            
        }
    }
}
