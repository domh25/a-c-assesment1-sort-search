using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algor_and_comlpx_search_and_sort_aplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            input input = new input();
            analyse analyse = new analyse();

            string answer;

            Console.WriteLine("1.read in 256 files\n2.read in 2048 files\n3.use merged share_1_256 and share_3_256\n4.use merged share_1_2048 and share_3_2048");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                string answer1;
                input.lower_access();
                int[] Share_1_256N = Array.ConvertAll(input.Share_1_256, int.Parse);
                int[] Share_2_256N = Array.ConvertAll(input.Share_2_256, int.Parse);
                int[] Share_3_256N = Array.ConvertAll(input.Share_3_256, int.Parse);
                Console.WriteLine("1.sort in accesending order\n2.sort in decending order\n3.search for item\n4.search for item or next nearest");
                answer1 = Console.ReadLine();

                if (answer1 == "1")
                {
                    string answer2;
                    Console.WriteLine("Enter which 256 file you would like to use");
                    answer2 = Console.ReadLine();
                    if (answer2 == "1")
                    {
                        analyse.low_order_bubbleA(Share_1_256N);
                        analyse.low_sorted(Share_1_256N);
                        analyse.low_twenty(Share_1_256N);
                    }
                    else if (answer2 == "2")
                    {
                        analyse.low_order_bubbleA(Share_2_256N);
                        analyse.low_sorted(Share_2_256N);
                        analyse.low_twenty(Share_2_256N);
                    }
                    else if (answer2 == "3")
                    {
                        analyse.low_order_bubbleA(Share_3_256N);
                        analyse.low_sorted(Share_3_256N);
                        analyse.low_twenty(Share_3_256N);
                    }

                }
                else if (answer1 == "2")
                {
                    string answer2;
                    Console.WriteLine("Enter which 256 file you would like to use");
                    answer2 = Console.ReadLine();
                    if (answer2 == "1")
                    {
                        analyse.low_order_bubbleD(Share_1_256N);
                        analyse.low_sorted(Share_1_256N);
                        analyse.low_twenty(Share_1_256N);
                    }
                    else if (answer2 == "2")
                    {
                        analyse.low_order_bubbleD(Share_2_256N);
                        analyse.low_sorted(Share_2_256N);
                        analyse.low_twenty(Share_2_256N);
                    }
                    else if (answer2 == "3")
                    {
                        analyse.low_order_bubbleD(Share_3_256N);
                        analyse.low_sorted(Share_3_256N);
                        analyse.low_twenty(Share_3_256N);
                    }
                }
                else if (answer1 == "3")
                {
                    string answer2;
                    int target;
                    Console.WriteLine("Enter which 256 file you would like to use");
                    answer2 = Console.ReadLine();
                    Console.WriteLine("enter value you are looking for");
                    target = Int32.Parse(Console.ReadLine());
                    if (answer2 == "1")
                    {
                        analyse.LineSearch(Share_1_256N, target);
                    }
                    else if (answer2 == "2")
                    {
                        analyse.LineSearch(Share_2_256N, target);
                    }
                    else if (answer2 == "3")
                    {
                        analyse.LineSearch(Share_3_256N, target);
                    }
                }
                else if (answer1 == "4")
                {
                    string answer2;
                    int target;
                    Console.WriteLine("Enter which 256 file you would like to use");
                    answer2 = Console.ReadLine();
                    Console.WriteLine("enter value you are looking for");
                    target = Int32.Parse(Console.ReadLine());
                    if (answer2 == "1")
                    {
                        analyse.LineSearch_plus(Share_1_256N, target);
                    }
                    else if (answer2 == "2")
                    {
                        analyse.LineSearch_plus(Share_2_256N, target);
                    }
                    else if (answer2 == "3")
                    {
                        analyse.LineSearch_plus(Share_3_256N, target);
                    }
                }
            }

            else if (answer == "2")
            {
                string answer1;
                input.higer_access();
                int[] Share_1_2048N = Array.ConvertAll(input.Share_1_2048, int.Parse);
                int[] Share_2_2048N = Array.ConvertAll(input.Share_2_2048, int.Parse);
                int[] Share_3_2048N = Array.ConvertAll(input.Share_3_2048, int.Parse);
                Console.WriteLine("1.sort in accesending order\n2.sort in decending order\n3.search for item\n4.search for item or next nearest");
                answer1 = Console.ReadLine();

                if (answer1 == "1")
                {
                    string answer2;
                    Console.WriteLine("Enter which 2048 file you would like to use");
                    answer2 = Console.ReadLine();
                    if (answer2 == "1")
                    {
                        analyse.high_order_insertionA(Share_1_2048N);
                        analyse.high_sorted(Share_1_2048N);
                        analyse.low_fifty(Share_1_2048N);
                    }
                    else if (answer2 == "2")
                    {
                        analyse.high_order_insertionA(Share_2_2048N);
                        analyse.high_sorted(Share_2_2048N);
                        analyse.low_fifty(Share_2_2048N);
                    }
                    else if (answer2 == "3")
                    {
                        analyse.high_order_insertionA(Share_3_2048N);
                        analyse.high_sorted(Share_3_2048N);
                        analyse.low_fifty(Share_3_2048N);
                    }

                }
                else if (answer1 == "2")
                {
                    string answer2;
                    Console.WriteLine("Enter which 2048 file you would like to use");
                    answer2 = Console.ReadLine();
                    if (answer2 == "1")
                    {
                        analyse.high_order_insertionD(Share_1_2048N);
                        analyse.high_sorted(Share_1_2048N);
                        analyse.low_fifty(Share_1_2048N);
                    }
                    else if (answer2 == "2")
                    {
                        analyse.high_order_insertionD(Share_2_2048N);
                        analyse.high_sorted(Share_2_2048N);
                        analyse.low_fifty(Share_2_2048N);
                    }
                    else if (answer2 == "3")
                    {
                        analyse.high_order_insertionD(Share_3_2048N);
                        analyse.high_sorted(Share_3_2048N);
                        analyse.low_fifty(Share_3_2048N);
                    }
                }
                else if (answer1 == "3")
                {
                    string answer2;
                    int target;
                    Console.WriteLine("Enter which 2048 file you would like to use");
                    answer2 = Console.ReadLine();
                    Console.WriteLine("enter value you are looking for");
                    target = Int32.Parse(Console.ReadLine());
                    if (answer2 == "1")
                    {
                        analyse.LineSearch(Share_1_2048N, target);
                    }
                    else if (answer2 == "2")
                    {
                        analyse.LineSearch(Share_2_2048N, target);
                    }
                    else if (answer2 == "3")
                    {
                        analyse.LineSearch(Share_3_2048N, target);
                    }
                }
                else if (answer1 == "4")
                {
                    string answer2;
                    int target;
                    Console.WriteLine("Enter which 2048 file you would like to use");
                    answer2 = Console.ReadLine();
                    Console.WriteLine("enter value you are looking for");
                    target = Int32.Parse(Console.ReadLine());
                    if (answer2 == "1")
                    {
                        analyse.LineSearch_plus(Share_1_2048N, target);
                    }
                    else if (answer2 == "2")
                    {
                        analyse.LineSearch_plus(Share_2_2048N, target);
                    }
                    else if (answer2 == "3")
                    {
                        analyse.LineSearch_plus(Share_3_2048N, target);
                    }
                }

            }

            else if (answer == "3")
            {
                string answer1;
                input.lower_merge();
                int[] Share_1_256N = Array.ConvertAll(input.Share_1_256, int.Parse);
                int[] Share_3_256N = Array.ConvertAll(input.Share_3_256, int.Parse);
                int[] Share_1_3_256 = Share_1_256N.Concat(Share_3_256N).ToArray();

                Console.WriteLine("1.sort in accesending order\n2.sort in decending order\n3.search for item\n4.search for item or next nearest");
                answer1 = Console.ReadLine();

                if (answer1 == "1")
                {

                    int[] result = analyse.mergeSortA(Share_1_3_256);
                    analyse.low_sorted(result);
                    analyse.low_twenty(result);
                }
                else if (answer1 == "2")
                {
                    int[] result = analyse.mergeSortD(Share_1_3_256);
                    analyse.low_sorted(result);
                    analyse.low_twenty(result);
                }
                else if (answer1 == "3")
                {
                    int target;
                    int[] result = analyse.mergeSortA(Share_1_3_256);

                    Console.WriteLine("what value would you like to search for?");
                    target = Int32.Parse(Console.ReadLine());
                    int search_result;
                    search_result = (int)analyse.BinSearch(result, target);
                    if (search_result == -1)
                    {
                        Console.WriteLine("target not found");
                    }
                    else
                    {
                        Console.WriteLine("the item " + target + " is found first at position " + search_result);
                    }

                }
                else if (answer1 == "4")
                {
                    int target;
                    int search_result;
                    int nearest_result;
                    int[] result = analyse.mergeSortA(Share_1_3_256);

                    Console.WriteLine("what value would you like to search for?");
                    target = Int32.Parse(Console.ReadLine());
                    search_result = (int)analyse.binSearch_plus(result, target);
                    Console.WriteLine("target " + target + " not found but item " + result[search_result] + " which is near origional target is found at position " + search_result);
                    if (target != result[search_result])
                    {
                        nearest_result = (int)analyse.BinSearch(result, result[search_result]);
                    }
                }
            }

            else if (answer == "4")
            {
                string answer1;
                input.higer_merge();
                int[] Share_1_2048N = Array.ConvertAll(input.Share_1_2048, int.Parse);
                int[] Share_3_2048N = Array.ConvertAll(input.Share_3_2048, int.Parse);
                int[] Share_1_3_2048 = Share_1_2048N.Concat(Share_3_2048N).ToArray();

                Console.WriteLine("1.sort in accesending order\n2.sort in decending order\n3.search for item\n4.search for item or next nearest");
                answer1 = Console.ReadLine();

                if (answer1 == "1")
                {
                    analyse.quickSortA(Share_1_3_2048);
                    analyse.high_sorted(Share_1_3_2048);
                    analyse.low_fifty(Share_1_3_2048);
                }
                else if (answer1 == "2")
                {
                    analyse.quickSortD(Share_1_3_2048);
                    analyse.high_sorted(Share_1_3_2048);
                    analyse.low_fifty(Share_1_3_2048);
                }
                else if (answer1 == "3")
                {
                    int target;
                    analyse.quickSortA(Share_1_3_2048);

                    Console.WriteLine("what value would you like to search for?");
                    target = Int32.Parse(Console.ReadLine());
                    int search_result;
                    search_result = (int)analyse.BinSearch(Share_1_3_2048, target);
                    if (search_result == -1)
                    {
                        Console.WriteLine("target not found");
                    }
                    else
                    {
                        Console.WriteLine("the item " + target + " is found first at position " + search_result);
                    }

                }
                else if (answer1 == "4")
                {
                    int target;
                    int search_result;
                    int nearest_result;
                    analyse.quickSortA(Share_1_3_2048);

                    Console.WriteLine("what value would you like to search for?");
                    target = Int32.Parse(Console.ReadLine());
                    search_result = (int)analyse.binSearch_plus(Share_1_3_2048, target);
                    Console.WriteLine("target " + target + " not found but item " + Share_1_3_2048[search_result] + " which is near origional target is found at position " + search_result);
                    if (target != Share_1_3_2048[search_result])
                    {
                        nearest_result = (int)analyse.BinSearch(Share_1_3_2048, Share_1_3_2048[search_result]);
                    }
                }



            }
           
        }
    }
}
