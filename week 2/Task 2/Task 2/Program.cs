using System;
using System.IO;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\input.txt");
            string s = sr.ReadLine();
            StreamWriter sw = new StreamWriter(@"D:\output.txt");
            string[] arr = s.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                int current = int.Parse(arr[i]);
                bool test = true;
                for (int j = 2; j <= Math.Sqrt(current); j++)
                {
                    if (current % j == 0)
                    {
                        test = false;
                        break;
                    }
                }
                if (test && current != 1)
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
