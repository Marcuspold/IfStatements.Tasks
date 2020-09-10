using System;
using System.Net.Cache;

namespace Week2IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string UserInput;
            Console.WriteLine("How Old are You?");
            UserInput = Console.ReadLine();
            Age = Int32.Parse(UserInput);
            if (Age < 18)
                Console.WriteLine($"You Are {Age}, You Are Too Young.");
            else if (Age > 18)
                Console.WriteLine($"You Are {Age}, you are old enough.");
            else
                  Console.WriteLine($"Congratulations! you are {Age}");
        }       

    }
}

