using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int space = 0; space < 5 - row - 1; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < row * 2 + 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
