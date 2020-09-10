using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            int First;
            int Second;
            string UserInput;
            Console.WriteLine("Insert a Number!");
            UserInput = Console.ReadLine();
            First = Int32.Parse(UserInput);
            Console.WriteLine("Insert a Second Number!");
            UserInput = Console.ReadLine();
            Second = Int32.Parse(UserInput);
           
            if (First == Second)
            { 
                Console.WriteLine("Are equal.");
            } else
            {
                Console.WriteLine("Are not equal.");
            }
            

            
            
           
           

        }
    }
}
