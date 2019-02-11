using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //read n
            for (int i = 0; i < n; i++) //row
            {
                for (int j = 0; j <= i; j++) //column numbers in each row increment one after each cycle
                {
                    Console.Write("[*]"); //output n time
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
