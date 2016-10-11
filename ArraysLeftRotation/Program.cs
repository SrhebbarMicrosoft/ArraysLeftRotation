using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int n = Convert.ToInt32(tokens[0]);
            int d = Convert.ToInt32(tokens[1]);
            d = d % n;

            int[] array = new int[n];
            string[] array_str = Console.ReadLine().Split();
            int cur = n - d;
            int i = 0;
            while (i != n)
            {
                if (cur == n)
                {
                    cur = 0;
                }
                array[cur] = Convert.ToInt32(array_str[i]);
                cur++;
                i++;
            }

            foreach (var a in array)
            {
                Console.Write(a + " ");
            }
        }
    }
}
