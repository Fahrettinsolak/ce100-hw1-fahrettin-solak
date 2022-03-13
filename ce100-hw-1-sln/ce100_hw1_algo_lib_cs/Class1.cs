using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_algo_lib_cs
{
    /****************************************************************************
    * Copyleft (L) 2022 CENG - All Rights Not Reserved
    * You may use, distribute and modify this code.
    ****************************************************************************/

    /**
     * @file ce100_hw1_algo_lib_cs
     * @author Fahrettin SOLAK
     * @date 13 March 2022
     *
     * @brief <b> HW-1 Functions </b>
     *
     * HW-1 Sample Lib Functions
     *
     * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
     *
     */

    public class Class1
    {


        //Insertion Sort

        /**
        *
        *	  @name  Insertion Sort
        *
        *	  @brief Insertion Sort function
        *
        *	  The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.
        *
        *	  @param  [in] fiIndex [\b int]  index of Insertion Sort in the serie
        *
        *	  @retval [\b int] Insertion Sort in the serie
        **/

        public static void InsSort(int[] mass)
        {
            for (int i = 1; i < mass.Length; i++)
            {
                int cur = mass[i];
                int j = i;
                while (j > 0 && cur < mass[j - 1])
                {
                    mass[j] = mass[j - 1];
                    j--;
                }
                mass[j] = cur;
            }
        }


        //Selection Sort

        /**
        *
        *	  @name  Selection Sort
        *
        *	  @brief Selection Sort function
        *
        *	  Drop low-order terms and ignore the constant coefficient in the leading term
        *
        *	  @param  [in] fiIndex [\b int]  Selection Sort 
        *
        *	  @retval [\b int] Selection Sort in the serie
        **/

        public static int[] SortArray(int[] numArray, int arrayLength)
        {
            int tempVar, smallestVal;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (numArray[j] < numArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                tempVar = numArray[smallestVal];
                numArray[smallestVal] = numArray[i];
                numArray[i] = tempVar;
            }
            return numArray;
        }


        //Recursive Power

        /**
        *
        *	  @name  Recursive Power
        *
        *	  @brief Recursive Power Calculator
        *
        *	  A recursive (recursive or recursive) function can be expressed as a function calling itself. In other words, they can be called self-invoking functions.
        *
        *	  @param  [in] fiIndex [\b int]  Recursive Power
        *
        *	  @retval [\b int] Recursive Power Calculation
        **/

        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }


        //Naive Power

        /**
        *
        *	  @name  Naive Power
        *
        *	  @brief Naive Power function
        *
        *	  The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.
        *
        *	  @param  [in] fiIndex [\b int]  Naive Power
        *
        *	  @retval [\b int] Naive Power function
        **/

        public static int Naivepower(int x, int y)
        {
            int pow = 1;

            for (int i = 1; i <= y; i++)
            {
                pow = pow * x;
            }

            return pow;
        }


        //Binary Search Recursive

        /**
        *
        *	  @name  Binary Search Recursive
        *
        *	  @brief Binary Search Recursive function
        *
        *	  It is one of the Divide and conquer algorithms types, where in each step, it halves the number of elements it has to search, making the average time complexity to O (log n). It works on a sorted array.
        *
        *	  @param  [in] fiIndex [\b int]  Binary Search Recursive
        *
        *	  @retval [\b int] Binary Search Recursive function
        **/

        public static int BinarySearchRecursive(int[] inputArray, int min, int max, int key)
        {


            int mid = min + (max - min) / 2;

            if (key == inputArray[mid])
            {
                return mid;
            }
            else if (key < inputArray[mid])
            {
                return BinarySearchRecursive(inputArray, min, mid - 1, key);
            }
            else
            {
                return BinarySearchRecursive(inputArray, mid + 1, max, key);
            }

        }


        //Binary Search Iterative

        /**
        *
        *	  @name  Binary Search Iterative
        *
        *	  @brief Binary Search Iterative function
        *
        *	  Given a sorted array of n integers and a target value, determine if the target exists in the array in logarithmic time using the binary search algorithm. If target exists in the array, print the index of it.
        *
        *	  @param  [in] fiIndex [\b int]  index of Binary Search Iterative in the serie
        *
        *	  @retval [\b int] Binary Search Iterative function
        **/

        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }


        //Recursive MergeSort

        /**
        *
        *	  @name  Recursive MergeSort
        *
        *	  @brief Recursive MergeSort function
        *
        *	  The recusrive approach requires creatiion multi branch recursion until the elements are comparable by one iterm. The the merging happens with DoMerge function by taking three arguments - start, mid and right
        *
        *	  @param  [in] fiIndex [\b int]  Recursive MergeSort 
        *
        *	  @retval [\b int] Recursive MergeSort function
        **/

        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //As this is a recursive algorithm, we need to have a base case to avoid an infinite recursion and therfore a stackoverflow
          
            if (array.Length <= 1)
                return array;
              
            int midPoint = array.Length / 2;
            
            left = new int[midPoint];

            
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            
            else
                right = new int[midPoint + 1];
           
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
             
            int x = 0;
            

            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            
            left = mergeSort(left);
           
            right = mergeSort(right);
            
            result = merge(left, right);
            return result;
        }

        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            
            while (indexLeft < left.Length || indexRight < right.Length)
            {
               
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
           
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }             

                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }


        //Master Method

        /**
        *
        *	  @name  Master Method
        *
        *	  @brief Master Method
        *
        *	   A powerful black-box method to solve recurrences.
        *      T(n) = aT(n/b) + f(n)
        *      The master method applies to recurrences of the form
        *      where a > 1, b > 1 , and f is asymptotically positive.
        *
        *	  @param  [in] fiIndex [\b int]  index of Master Method in the serie
        *
        *	  @retval [\b int] Master Method
        **/
        public static string MasterMethod(int param, Func<int, string> function)
        {
            return function(param);
        }
        // Call via:
        string result = MasterMethod(2, a =>
        {
            if (a == 1)
            {
                return "if";
            }
            else
            {
                return "else";
            }
        });
    }

}


