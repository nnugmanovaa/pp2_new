using System;
using System.IO;
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //read file;
            StreamReader sr = new StreamReader(@"C:\Users\user\Desktop\pp2_!\week 2\Task 1\Input.txt");
            string s;
            //read each line in the file
            while ((s = sr.ReadLine()) != null)
            {
                //reload to char array
                char[] chararray = s.ToCharArray();
                //reverse char array 
                Array.Reverse(chararray);
                //reload it to string 
                string check = new string(chararray);
                if (check == s)// if reverse string and origin are equal , it is a palindrome 
                    Console.WriteLine("Yes");
                else Console.WriteLine("No");

            }
            Console.ReadKey();
        }
    }
}
