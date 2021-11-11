using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class q9
    {
        public void solution()
        {
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            Console.WriteLine(hasOnlyLetters(str));
        }
        public  bool hasOnlyLetters(string str)
        {
            int temp = -1;

            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i];
                if (temp >= 48 && temp <= 57)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
