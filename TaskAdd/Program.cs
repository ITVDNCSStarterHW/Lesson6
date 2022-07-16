using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int hieght;
            int width;

            Console.WriteLine("Choose hieght and width of rectangle");
            hieght = Convert.ToInt32(Console.ReadLine());
            width = Convert.ToInt32(Console.ReadLine());

            for (int i = width; i > 0; i--)
            {
                for (int j = hieght; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
