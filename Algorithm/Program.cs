using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 17, 3, 1, 12, 18, 7, 20, 13, 10, 9, 2, 19, 4, 14, 6, 5, 15, 8, 16 };

            int[] b = ShellSort.Sort(a);

            for (int i = 0; i < b.Length; i++)
            {
                Console.Out.WriteLine(b[i]);
            }

        }

        
    }
}
