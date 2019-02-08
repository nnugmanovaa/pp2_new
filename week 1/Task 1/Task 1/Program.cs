using System;
using System.Collections.Generic;
namespace Task_1
{
    class Program
    {
        //function to check for prime numbers
        public static bool check(string n)
        {
            //converting a string into an integer
            int num = int.Parse(n);
            if (num <= 1)
                return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                    if (num % i == 0)
                        return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            //creating a list to collect prime numbers
            List<string> primes = new List<string>();
            //reading the first line of an input 
            string s1 = Console.ReadLine();
            //converting string into an integer
            int n = int.Parse(s1);
            //reading the second line of an input 
            string s2 = Console.ReadLine();
            //adding numbers to an array by separating them 
            string[] arr = s2.Split();
            //running through the array and checking every element for prime 
            for (int i = 0; i < n; i++)
            {
                if (check(arr[i]))
                //adding prime numbers to the list 
                {
                    primes.Add(arr[i]);
                }
            }//printing the amount of prime elements
            Console.WriteLine(primes.Count);
            //taking element into a string and separating them by the space 
            var cmb = string.Join(" ", primes);
            //printing the list of prime numbers in a single line 
            Console.WriteLine(cmb);
            Console.ReadKey();
        }
    }
}
