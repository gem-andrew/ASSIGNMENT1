using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class q7
    {
        public void solution()
        {
            char char1, char2, char3;
            Console.Write("Input letter: ");
            char1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Input letter: ");
            char2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Input letter: ");
            char3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}", char3, char2, char1);
        }
    }
}
