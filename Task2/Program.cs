using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine("What Is Your Year Of Birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            if (Age < 18)
                Console.WriteLine($"You Are {Age}, You Are Too Young To Get a Driving License.");
            else if (Age > 18)
                Console.WriteLine($"You Are {Age}, You Are Already Allowed To Get a Driving License.");
            else
                Console.WriteLine($"Congrulations! You are old enough to get a driving license.");
            
        }   
            


        
    }      
}
