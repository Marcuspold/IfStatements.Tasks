using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            Console.WriteLine("Whats your favorite animal?");
            UserInput = Console.ReadLine();

            if (UserInput == "Cat")
            {
                Console.WriteLine("You Like Cats");
            }
            else if (UserInput == "Dog iiiiiiii")
            {
                Console.WriteLine("You are Partygoer.");
            } else
            {
                Console.WriteLine($"You Are a {UserInput} friend.");
            }
        }  
    }    
}
