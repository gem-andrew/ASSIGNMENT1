using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class q6
    {
        public void solution()
        {
            string def_Username = "username";
            string def_Password = "password";
            int counter = 0;
            string username;
            string password;
            while (counter < 3)
            {
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
                if (username == def_Username && password == def_Password)
                {
                    Console.WriteLine("Successfully Logged in");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong credentials, try again.");
                    counter += 1;
                }
            }
            if (counter == 3)
            {
                Console.WriteLine("User was rejected after 3 failed attempts");
            }

        }
    }
}
