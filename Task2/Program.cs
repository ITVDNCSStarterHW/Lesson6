using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int result = 0;

            Choose:
            Console.WriteLine("Choose a and b (a < b)");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a < b. Repeat your choose please.");
                goto Choose;
            }

            for (int i = a + 1; i < b; i++)
            {
                result = result + i;
                Console.Write(i);

                if (i != b - 1)
                {
                    Console.Write(" + ");
                }
            }
            Console.Write(" = " + result);

            Console.ReadLine();
        }
    }
}
