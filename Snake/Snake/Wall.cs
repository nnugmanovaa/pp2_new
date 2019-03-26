﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snake
{
    [Serializable]
    public class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;
        public Wall() { }
        public void Level(int level)
        {
            StreamReader sr = new StreamReader(@"C:\Users\user\Desktop\sketch\snakelevel" + Convert.ToString(level) + ".txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string l = sr.ReadLine();
                for (int j = 0; j < l.Length; j++)
                {
                    if (l[j] == '*')
                    {
                        body.Add(new Point(j, i));
                    }
                }
            }
            sr.Close();
        }
        public Wall(int level)
        {
            body = new List<Point>();
            sign = "x";
            color = ConsoleColor.Blue;
            Level(level);
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}

