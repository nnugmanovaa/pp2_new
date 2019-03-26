using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    [Serializable]
    public class Point
    {
        public int x;
        public int y;
        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
