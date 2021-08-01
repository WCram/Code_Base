using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Base
{
    static class Code_Sol
    {
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string c = (j < n - i) ? " " : "#";
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        } // staircase

        public static void miniMaxSum(List<int> arr)
        {
            long min = int.MaxValue;
            long max = int.MinValue;
            long sum = 0;

            foreach (int i in arr)
            {
                if (i < min) min = i;
                if (i > max) max = i;
                sum += i;
            }
            string maxString = (sum - min) + "";
            string minString = (sum - max) + "";

            Console.WriteLine(minString + " " + maxString);
        } // miniMaxSum

    } // class
}// namespace
