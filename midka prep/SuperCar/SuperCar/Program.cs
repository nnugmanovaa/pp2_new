using System;

namespace SuperCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Car car = new Car(1, 1);
            Game game = new Game(car);
            game.Start();
        }
    }
}
