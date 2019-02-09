using System;

namespace Task_2
{
    class Program
    {
        class Student//create class
        {
            string name, id;//class items name , id , year 
            int year = 0;

            public Student(string name, string id)//constructor with input of 2 parameters name and id
            {
                this.name = name;//assignment
                this.id = id;

            }
            public void toPrint()//method to print class elements, name and id(access)
            {
                Console.WriteLine("Name of student :{0} ", name);
                Console.WriteLine("ID of student: " + id);
            }
            public void inc()//method to increment year of study of student
            {
                this.year++;
                Console.WriteLine("Year of student increased by one, now is {0}", year);
            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("Nargiza", "18BD110637");//create new object of class Student and assign values
            s1.toPrint(); //call method print of class student
            s1.inc();//call method inc of class student
            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
