using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace Task_1
{
    public class Complex
    {
        public int real;
        public int imaginary;
        public Complex () { }
        public Complex(int real , int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public override string ToString()
        {
            return (string.Format("{0} + {1}i", real, imaginary));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Complex c = new Complex(a, b);
            FileStream fs = new FileStream("comp.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(Complex));
            xm.Serialize(fs, c);
            fs.Close();
            FileStream fs1 = new FileStream("comp.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            Complex s = xs.Deserialize(fs1) as Complex;
            Console.WriteLine(s);
            fs1.Close();
            Console.ReadKey();
        }
    }
}
