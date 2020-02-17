using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;

namespace SortTest
{
    [TestClass]
    public class SortingTest
    {
       private int[] arr;
       private Random random = new Random();
        

        [TestMethod]
        public void SetUpScenary() 
        {
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Sorting.SetArr(arr);
        }

        [TestMethod]
        public void SetUpScenary1()
        {
            arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Sorting.SetArr(arr);
        }

        [TestMethod]
        public void SetUpScenary2()
        {
            arr = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next();
            }
            Sorting.SetArr(arr);
        }

        [TestMethod]
        public void SetUpScenary3()
        {
            arr = new int[10000];
            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = random.Next();
                int j = arr.Length;
                arr[i] = j;
                j--;
            }
            Sorting.SetArr(arr);
        }

        [TestMethod]
        public void BubbleTest()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary();
                Sorting.Bubble();
            }
           
        }

        [TestMethod]
        public void BubbleTest1() 
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary1();
                Sorting.Bubble();
            }
        }

        [TestMethod]
        public void BubbleTest2()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary2();
                Sorting.Bubble();
            }
        }

        /*[TestMethod]
        public void BubbleTest3()
        {
            for (int k = 0; k < 1000; k++)
            {
                SetUpScenary3();
                Sorting.Bubble();
            }
        }*/

        [TestMethod]
        public void RecursiveBubbleTest()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary();
                Sorting.RecursiveBubble(arr, arr.Length);
            }
        }

        [TestMethod]
        public void RecursiveBubbleTest1()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary1();
                Sorting.RecursiveBubble(arr, arr.Length);
            }
        }

        [TestMethod]
        public void RecursiveBubbleTest2()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary2();
                Sorting.RecursiveBubble(arr, arr.Length);
            }
        }

        /*[TestMethod]
        public void RecursiveBubbleTest3()
        {
            for (int k = 0; k < 1000; k++)
            {
                SetUpScenary3();
                Sorting.RecursiveBubble(arr, arr.Length);
            }
            
        }*/

        [TestMethod]
        public void SelectionSort() 
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary();
                Sorting.Selection();
            }
        }

        [TestMethod]
        public void SelectionSort1()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary1();
                Sorting.Selection();
            }
        }

        [TestMethod]
        public void SelectionSort2()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary2();
                Sorting.Selection();
            }
        }

        [TestMethod]
        public void SelectionSort3()
        {
            for (int j = 0; j < 1000; j++)
            {
                SetUpScenary3();
                Sorting.Selection();
            }
            //Sorting.RecurisveSelection(arr, arr.Length, 0);
        }
    }
}
