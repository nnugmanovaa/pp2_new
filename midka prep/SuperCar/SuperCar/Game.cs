using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SuperCar
{
    public class Game
    {
        public Car car;

        public Game(Car car )
        {
            this.car = car;
        }

        public void Start()
        {
            Thread thread = new Thread(MoveCar);
            thread.Start();

            while(true)
            {
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                car.ChangeDirection(consoleKey);
            }
        }

        public void MoveCar()
        {
            while(true)
            {
                car.Move();
                car.Draw();
                Thread.Sleep(100);
            }
        }
    }
}
