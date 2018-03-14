using System;

namespace FizzBuzz.Client
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter beginning number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number:");
            int e = Convert.ToInt32(Console.ReadLine());

            if (e < 1)
            {
                Console.WriteLine("Setting e to 1.");
                e = 1;
            }

            if (b > e)
            {
                Console.WriteLine("Setting end value to 10 after beginning value.");
                e = b + 10;
            }

            Console.WriteLine("\nStarting Fizzbuzz from " + b.ToString() + " to " + e.ToString() + " .\n");

            int fCount = 0;
            int bCount = 0;
            int fbCount = 0;

            string fizzname = "";
            for (int i = b; i <= e; i++)
            {
                if (i%5 ==0 && i%3 == 0)
                {
                    fizzname = "FizzBuzz";
                    fbCount++;
                }
                else if (i%3 == 0)
                {
                    fizzname = "Fizz";
                    fCount++;
                }
                else if (i%5 == 0) 
                {
                    fizzname = "Buzz";
                    bCount++;
                }
                
                //Output FizzBuzz Name
                if (fizzname == "")
                    Console.WriteLine(i);
                else
                    Console.WriteLine(fizzname);

                fizzname = "";
            }

            Console.WriteLine("\n\nThe Fizz count is: " + fCount.ToString());
            Console.WriteLine("The Buzz count is: " + bCount.ToString());
            Console.WriteLine("The FizzBuzz count is: " + fbCount.ToString());

        }


    }
}
