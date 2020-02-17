using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;

namespace SortTest
{
    [TestClass]
    public class SortingTest
    {
        int[] arr;
        Random random = new Random();
        

        [TestMethod]
        public void SetUpScenary() 
        {
            //double num = Math.Pow(10, 2);
            arr = new int[Convert.ToInt64(Math.Pow(10, 1))];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Sorting.SetArr(arr);
        }

        [TestMethod]
        public void SetUpScenary1()
        {
            arr = new int[Convert.ToInt64(Math.Pow(10, 2))];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Sorting.SetArr(arr);
        }

        [TestMethod]
        public void SetUpScenary2()
        {
            arr = new int[Convert.ToInt64(Math.Pow(10, 3))];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Sorting.SetArr(arr);
        }

        [TestMethod]
        public void SetUpScenary3()
        {
            arr = new int[Convert.ToInt64(Math.Pow(10, 4))];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Sorting.SetArr(arr);
        }

        [TestMethod]
        public void BubbleTest()
        {
            SetUpScenary();
            Sorting.Bubble();
            Sorting.RecursiveBubble(arr, arr.Length);

            /*SetUpScenary1();
            Sorting.Bubble();
            Sorting.RecursiveBubble(arr, arr.Length);

            SetUpScenary2();
            Sorting.Bubble();
            Sorting.RecursiveBubble(arr, arr.Length);

            SetUpScenary3();
            Sorting.Bubble();
            Sorting.RecursiveBubble(arr, arr.Length);*/
        }

        [TestMethod]
        public void SelectionSort() 
        {
            SetUpScenary();
            Sorting.Selection();
            Sorting.RecurisveSelection(arr, arr.Length, 0);
        }
    }
}
