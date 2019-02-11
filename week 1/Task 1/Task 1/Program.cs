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
            List<string> primes = new List<string>();//creating a list to collect prime numbers
            string s1 = Console.ReadLine(); //reading the first line of an input 
            int n = int.Parse(s1);//converting string into an integer
            string s2 = Console.ReadLine();//reading the second line of an input 
            string[] arr = s2.Split();//adding numbers to an array by separating them 
            for (int i = 0; i < n; i++)//running through the array and checking every element for prime 
            {
                if (check(arr[i])) //adding prime numbers to the list 
                {
                    primes.Add(arr[i]);
                }
            }
            Console.WriteLine(primes.Count);//printing the amount of prime elements
            var cmb = string.Join(" ", primes);//taking element into a string and separating them by the space 
            Console.WriteLine(cmb);//printing the list of prime numbers in a single line 
            Console.ReadKey();
        }
    }
}
