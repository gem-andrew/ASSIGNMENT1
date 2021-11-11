using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class q5
    {
        public void solution()
        {
            Console.Write("Input a first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine((num1 + num2) * 3);
            }
            else
            {
                Console.WriteLine(num1 + num2);
            }

        }
    }
}
