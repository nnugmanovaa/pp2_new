using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCar
{
    public class Car
    {
        public int x;
        public int y;
        public Direction direction;

        public enum  Direction
        {
            None,
            Up,
            Down,
            Left,
            Right
        }

        public Car(int x,int y)
        {
            this.x = x;
            this.y = y;
            direction = Direction.None;
        }

        public void Move()
        {
            if (direction == Direction.None)
                return;
            if (direction == Direction.Up)
                y--;
            if (direction == Direction.Down)
                y++;
            if (direction == Direction.Left)
                x--;
            if (direction == Direction.Right)
                x++;
        }

        public void ChangeDirection(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.UpArrow)
                direction = Direction.Up;
            if (keyInfo.Key == ConsoleKey.DownArrow)
                direction = Direction.Down;
            if (keyInfo.Key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            if (keyInfo.Key == ConsoleKey.RightArrow)
                direction = Direction.Right;
        }

        public void Draw()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(x, y);
            Console.Write("<##>");
        }


    }
}
