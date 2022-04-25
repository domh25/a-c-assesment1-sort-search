using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algor_and_comlpx_search_and_sort_aplication
{
    public class analyse
    {
        public void low_order_bubbleA(int[] a)
        {
            int counter = 0;
            for (int i = 0; i < 256 - 1; i++)
            {
                for (int j = 0; j < 256 - 1 - i; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        counter++;
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(counter + "steps taken");
        }
        public void low_twenty(int[] a)
        {
            Console.WriteLine("\nEvery 20th value\n");
            for (int i = 0; i < a.Length; i = i + 20)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void low_sorted(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void low_order_bubbleD(int[] a)
        {
            int counter = 0;
            for (int i = 0; i < 256 - 1; i++)
            {
                for (int j = 0; j < 256 - 1 - i; j++)
                {
                    if (a[j + 1] > a[j])
                    {
                        counter++;
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(counter + " steps taken");

        }
        public void high_order_insertionA(int[] a)
        {
            int counter = 0;
            int numSorted = 1; 
            int index; 
            while (numSorted < a.Length)
            {
                int temp = a[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp < a[index - 1])
                    {
                        counter++;
                        a[index] = a[index - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                a[index] = temp;
                numSorted++;

            }
            Console.WriteLine(counter + " steps taken");
        }
        public void high_order_insertionD(int[] a)
        {
            int counter = 0;
            int numSorted = 1;
            int index;
            while (numSorted < a.Length)
            {
                int temp = a[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp > a[index - 1])
                    {
                        counter++;
                        a[index] = a[index - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                a[index] = temp;
                numSorted++;

            }
            Console.WriteLine(counter + " steps taken");
        }
        public void low_fifty(int[] a)
        {
            Console.WriteLine("\nEvery 50th value\n");
            for (int i = 0; i < a.Length; i = i + 50)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void high_sorted(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public void LineSearch(int[] a, int num)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                counter++;
                if (a[i] == num)
                {
                    Console.WriteLine("The target value " + num + " is found at position " + i);
                }
            }
            Console.WriteLine("posistions start at 0\nEnd of file\nif no positions have shown\nthey have not been found");
            Console.WriteLine(counter + " steps taken");
        }
        public void LineSearch_plus(int[] a, int num)
        {
            int counter = 0;
            bool found = false;
            int loop = 0;
            int diff = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    counter++;
                    Console.WriteLine("The target value " + num + " is found at position " + i);

                    found = true;
                }
            }

            while (found == false)
            {
               
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == num - loop)
                    {
                        counter++;
                        diff = -loop;
                        loop = 1;
                        found = true;
                    }
                }

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == num + loop)
                    {
                        counter++;
                        diff = loop;
                        loop = 2;
                        found = true;
                    }
                }
                loop++;
            }
            
            if (loop == 1)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == num+diff)
                    {
                        counter++;
                        Console.WriteLine("The target value " + num+diff + " is found at position " + i);
                    }
                }
            }
            else if (loop == 2)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == num+diff)
                    {
                        counter++;
                        Console.WriteLine("The target value " + num+diff + " is found at position " + i);
                    }
                }
            }
            Console.WriteLine(counter + " steps taken");
        }

        public static int[] mergeSortA(int[] array)
        {
            int counter = 0;
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            if (array.Length <= 1)
            {
                Console.WriteLine(counter + " steps taken");
                return array;
            }

            int midPoint = array.Length / 2;
            left = new int[midPoint];

            if (array.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint + 1];
            }

            for (int i = 0; i < midPoint; i++)
            {
                counter++;
                left[i] = array[i];
            }
            
            int x = 0;

            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }

            left = mergeSortA(left);
            right = mergeSortA(right);
            result = mergeA(left, right);
            Console.WriteLine(counter + " steps taken");
            return result;
        }

     
        public static int[] mergeA(int[] left, int[] right)
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


        public static int[] mergeSortD(int[] array)
        {
            int counter = 0;
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            if (array.Length <= 1)
            {
                Console.WriteLine(counter + " steps taken");
                return array;
            }
            int midPoint = array.Length / 2;
            left = new int[midPoint];

            if (array.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint + 1];
            }
            for (int i = 0; i < midPoint; i++)
            {
                counter++;
                left[i] = array[i];
            }

            int x = 0;

            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            left = mergeSortD(left);
            right = mergeSortD(right);
            result = mergeD(left, right);
            Console.WriteLine(counter + " steps taken");
            return result;
        }

        public static int[] mergeD(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] >= right[indexRight])
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

        public static object BinSearch(int[] a, int target)
        {
            int counter = 0;
            int min = 0;
            int max = a.Length - 1;
            int first_pos;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (target == a[mid])
                {
                    Console.WriteLine("\nTarget found\n");
                    first_pos = ++mid;
                    while(target == a[mid])
                    {
                        counter++;
                        mid++;
                        Console.WriteLine("the item " + target + " has been found at position " + mid);    
                    }
                    return first_pos;
                }
                else if (target < a[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine(counter + " steps taken");
            return -1;

        }


        public static object binSearch_plus(int[] a, int target)
        {
            int counter = 0;
            int first = 0;
            int last = a.Length - 1;
            int mid = 0;
            int first_pos;
            do
            {
                mid = first + (last - first) / 2;
                if (target > a[mid])
                    first = mid + 1;
                else
                    last = mid - 1;
                if (a[mid] == target)
                {
                    counter++;
                    Console.WriteLine("\nTarget found\n");
                    first_pos = ++mid;
                    while (target == a[mid])
                    {
                        mid++;
                        Console.WriteLine("the item " + target + " has been found at position " + mid);
                    }
                    Console.WriteLine(counter + " steps taken");
                    return first_pos;
                }
            } while (first <= last);
            Console.WriteLine(counter + " steps taken");
            return mid;
            
        }

        public static void quickSortA(int[] data)
        {
          
            quick_SortA(data, 0, data.Length - 1);
        }

        public static void quick_SortA(int[] data, int left, int right)
        {
            int counter = 0;
            int i, j;
            int pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2];
            do
            {
                while ((data[i] < pivot) && (i < right)) i++;
                while ((pivot < data[j]) && (j > left)) j--;
                if (i <= j)
                {
                    counter++;
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) quick_SortA(data, left, j);
            if (i < right) quick_SortA(data, i, right);
            Console.WriteLine(counter + " steps taken");
        }

        public static void quickSortD(int[] data)
        {
            quick_SortD(data, 0, data.Length - 1);
        }

        public static void quick_SortD(int[] data, int left, int right)
        {
            int counter = 0;
            int i, j;
            int pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2];
            do
            {
                while ((data[i] > pivot) && (i < right)) i++;
                while ((pivot > data[j]) && (j > left)) j--;
                if (i <= j)
                {
                    counter++;
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left < j) quick_SortD(data, left, j);
            if (i < right) quick_SortD(data, i, right);
            Console.WriteLine(counter + " steps taken");
        }


    }
}