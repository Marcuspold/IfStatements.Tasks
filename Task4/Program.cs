using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Whats your number?");
            string UserInput = Console.ReadLine();
            int Number = Int32.Parse(UserInput);

            if (Number > 0)
            {
                Console.WriteLine("The Number is positive.");
            }
            else if (Number < 0)
            {
                Console.WriteLine("The Number is negative.");
            }
            else
            {
                Console.WriteLine("The Number is 0.");
            }


        }
    }
}
