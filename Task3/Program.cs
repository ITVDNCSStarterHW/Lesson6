using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 5;
            int w = 7;
            /*
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
            */
            for (int i = 0; i < h; i++)
            {
                for (int j = h; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

            for (int i = h; i != 0; i--)
            {
                for (int j = h; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

            
        }
    }
}
