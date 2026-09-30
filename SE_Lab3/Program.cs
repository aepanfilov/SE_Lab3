using System;
using System.Linq;

namespace SE_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] msv = { -1, 2, 3, -4 };
            var res = from n in msv
                      where n > 0
                      select n;
            foreach (int x in res)
                Console.WriteLine(x);
        }
    }
}
