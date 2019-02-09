using System;
using System.IO;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\input.txt");//read input
            string s = sr.ReadLine();//read the line
            StreamWriter sw = new StreamWriter(@"D:\output.txt");
            string[] arr = s.Split();//split the line by space 
            for (int i = 0; i < arr.Length; i++)//running through the elements of array  
            {
                int current = int.Parse(arr[i]);//reload to integer 
                bool test = true;
                for (int j = 2; j <= Math.Sqrt(current); j++) 
                {
                    if (current % j == 0)//checking for the primes 
                    {
                        test = false;
                        break;//if element is not prime stop 
                    }
                }
                if (test && current != 1) // if the element is prime and not equal to 1 print it
                {
                    sw.Write(current + " "); 
                }
            }
            sr.Close();
            sw.Close();
            Console.ReadKey();
        }
    }
}
