using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class q8
    {
        bool checkUpperCase(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }
        public void solution()
        {
            Console.WriteLine("enter a 3 character string");
            string s = Console.ReadLine();
            Console.WriteLine(checkUpperCase(s));
        }
    }
}
