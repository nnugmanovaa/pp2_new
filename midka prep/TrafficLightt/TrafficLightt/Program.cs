using System;
using System.Threading;

namespace TrafficLightt
{
    class Program
    {
        public static int cnt = 0;

        public static void ShowTrffic()
        {
            while(true)
            {
                Console.Clear();
                cnt++;
                if(cnt==4)
                {
                    cnt = 1;
                }
                for(int i=0; i<3;i++)
                {
                    if (cnt == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("* * * *");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < 3; i++)
                {
                    if (cnt == 2)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("* * * *");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < 3; i++)
                {
                    if (cnt == 3)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("* * * *");
                }
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread thread = new Thread(ShowTrffic);
            thread.Start();
        }
    }
}
