using System;
using System.IO;
using System.Xml.Serialization;

namespace ComplexNum
{
    public class Complex
    {
        public int real;
        public int imaginary;

        public Complex() { }

        public Complex(int real,int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", real, imaginary));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Complex cn = new Complex(n, m);

            FileStream fs = new FileStream("a.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(Complex));
            xm.Serialize(fs, cn);
            fs.Close();

            FileStream fs1 = new FileStream("a.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex s =xs.Deserialize(fs1) as Complex;
            Console.WriteLine(s);
            fs1.Close();
            Console.ReadKey();
        }
    }
}
