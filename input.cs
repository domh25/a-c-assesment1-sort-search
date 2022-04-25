using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace algor_and_comlpx_search_and_sort_aplication
{
    public class input
    {
        public string[] Share_1_256 = System.IO.File.ReadAllLines(@"C:\Users\pc\Documents\c# uni\algor and comlpx search and sort aplication\Share_1_256.txt");
        public string[] Share_2_256 = System.IO.File.ReadAllLines(@"C:\Users\pc\Documents\c# uni\algor and comlpx search and sort aplication\Share_2_256.txt");
        public string[] Share_3_256 = System.IO.File.ReadAllLines(@"C:\Users\pc\Documents\c# uni\algor and comlpx search and sort aplication\Share_3_256.txt");

        public string[] Share_1_2048 = System.IO.File.ReadAllLines(@"C:\Users\pc\Documents\c# uni\algor and comlpx search and sort aplication\Share_1_2048.txt");
        public string[] Share_2_2048 = System.IO.File.ReadAllLines(@"C:\Users\pc\Documents\c# uni\algor and comlpx search and sort aplication\Share_1_2048.txt");
        public string[] Share_3_2048 = System.IO.File.ReadAllLines(@"C:\Users\pc\Documents\c# uni\algor and comlpx search and sort aplication\Share_1_2048.txt");
        

        public void lower_access()
        {


            Console.WriteLine("Contents of Share_1_256.txt = ");
            foreach (string line in Share_1_256)
            {
                Console.WriteLine(line);
            }
            

            Console.WriteLine("Contents of Share_2_256.txt = ");
            foreach (string line in Share_2_256)
            { 
                Console.WriteLine(line);
            }

            Console.WriteLine("Contents of Share_3_256.txt = ");
            foreach (string line in Share_3_256)
            {
                 Console.WriteLine(line);
            }

        }

        public void higer_access()
        {
            Console.WriteLine("Contents of Share_1_2048.txt = ");
            foreach (string line in Share_1_2048)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Contents of Share_2_2048.txt = ");
            foreach (string line in Share_2_2048)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Contents of Share_3_2048.txt = ");
            foreach (string line in Share_3_2048)
            {
                Console.WriteLine(line);
            }
        }

        public void lower_merge()
        {
            Console.WriteLine("Contents of Share_1_2048.txt = ");
            foreach (string line in Share_1_2048)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Contents of Share_3_2048.txt = ");
            foreach (string line in Share_3_2048)
            {
                Console.WriteLine(line);
            }
        }

        public void higer_merge()
        {
            Console.WriteLine("Contents of Share_1_2048.txt = ");
            foreach (string line in Share_1_2048)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Contents of Share_3_2048.txt = ");
            foreach (string line in Share_3_2048)
            {
                Console.WriteLine(line);
            }
        }
    }
    
}
