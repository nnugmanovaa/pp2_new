using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    public class MarkList
    {
        public List<Mark> Marks;
        public MarkList()
        {
            Marks = new List<Mark>();
        }

        public void Save(MarkList M)
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(MarkList));
            xs.Serialize(fs, M);
            fs.Close();
        }
        public void Show()
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(MarkList));
            MarkList M = xs.Deserialize(fs) as MarkList;
            for (int i = 0; i < M.Marks.Count; i++)
            {
                Console.WriteLine(M.Marks[i]);
            }
        }
    }
    public class Mark
    {
        public double point;
        public Mark() { }

        public Mark(double point)
        {
            this.point = point;
        }

        public string getLetter()
        {
            if (point >= 95) return "A";
            if (point >= 90 && point < 95) return "A-";
            if (point >= 85 && point < 90) return "B+";
            if (point >= 80 && point < 85) return "B";
            if (point >= 75 && point < 80) return "B-";
            if (point >= 70 && point < 75) return "C+";
            if (point >= 65 && point < 70) return "C";
            if (point >= 60 && point < 65) return "C-";
            if (point >= 55 && point < 60) return "D+";
            if (point >= 50 && point < 55) return "D";
            return "F";
        }
        public override string ToString()
        {
            return "Mark is " + this.point + " " + this.getLetter();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mark a = new Mark(95);
            Mark b = new Mark(55);
            Mark c = new Mark(70);
            MarkList M = new MarkList();
            M.Marks.Add(a);
            M.Marks.Add(b);
            M.Marks.Add(c);
            M.Save(M);
            M.Show();
            Console.ReadKey();
        }
    }
}
