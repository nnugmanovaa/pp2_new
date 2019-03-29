using System;
using System.IO;
using System.Xml.Serialization;

namespace Serializ
{
    public class Train
    {
        public string begin;
        public string end;

        public Train() { }

        public Train(string begin,string end)
        {
            this.begin = begin;
            this.end = end;
        }

        public string FindTime()
        {
            int n = int.Parse(begin.Substring(0, 2));
            int m = int.Parse(begin.Substring(3, 2));

            int k = int.Parse(end.Substring(0, 2));
            int x = int.Parse(end.Substring(3, 2));

            int hour = k - n;
            int minute = x - m;
            if(minute<0)
            {
                minute = 60 + (x - m);
                hour--;
            }

            return hour.ToString() + ":" + minute.ToString();
        }

        public void Ser()
        {
            FileStream fs = new FileStream("time.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(string));
            xm.Serialize(fs, this.FindTime());
            fs.Close();
        }

        public void Des()
        {
            FileStream fs = new FileStream("time.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(string));
            string output = xs.Deserialize(fs) as string;
            Console.WriteLine(output);
            fs.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            string e = Console.ReadLine();

            Train t = new Train(b, e);
            t.Ser();
            t.Des();
            Console.ReadKey();
        }
    }
}
