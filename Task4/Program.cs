using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int res = n;

            do
            {
                res = res * (n - 1);
                n--;
            }
            while (n != 1);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
