using System;
using System.Threading;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread thread = new Thread(MoveCar);
            thread.Start();
        }

        static void MoveCar()
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                for(int i=1; i<=60; i++)
                {
                    Console.SetCursorPosition(i, 1);
                    Console.Write("#>>");
                    Thread.Sleep(50);
                    Console.Clear();
                }

                for (int i = 1; i <= 25; i++)
                {
                    Console.SetCursorPosition(60, i);
                    Console.Write("#");
                    Thread.Sleep(100);
                    Console.Clear();
                }

                for (int i = 60; i >= 1; i--)
                {
                    Console.SetCursorPosition(i, 25);
                    Console.Write("<<#");
                    Thread.Sleep(50);
                    Console.Clear();
                }

                for (int i = 25; i >= 1; i--)
                {
                    Console.SetCursorPosition(1, i);
                    Console.Write("#");
                    Thread.Sleep(100);
                    Console.Clear();
                }

            }
        }
    }
}
