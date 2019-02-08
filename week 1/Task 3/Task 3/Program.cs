using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //read size of array
            int[] a = new int[n]; //create array of size n
            string[] ss = Console.ReadLine().Split(); //split sequence
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(ss[i]); //from string to int each element 
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} {0} ", a[i]); //double output each element of array
            }
            Console.ReadLine();
        }
    }
}
