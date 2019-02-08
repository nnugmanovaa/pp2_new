using System;

namespace Task_2
{
    class Program
    {
        class Student
        {
            string name, id;
            int year = 0;

            public Student(string name, string id)
            {
                this.name = name;
                this.id = id;

            }
            public void toPrint()
            {
                Console.WriteLine("Name of student :{0} ", name);
                Console.WriteLine("ID of student: " + id);
            }
            public void inc()
            {
                this.year++;
                Console.WriteLine("Year of student increased by one, now is {0}", year);
            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("Nargiza", "18BD110637");
            s1.toPrint();
            s1.inc();
            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
