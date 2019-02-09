using System;
using System.IO;
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new file
            FileStream fs = new FileStream(@"C:\Users\user\Desktop\pp2_!\week 2\Task 4\input1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //close the file
            fs.Close();
            //copy file from the path, where exist file to file1
            File.Copy(@"C:\Users\user\Desktop\pp2_!\week 2\Task 4\input1.txt", @"C:\Users\user\Desktop\pp2_!\week 2\Task 4\copy.txt");
            //delete file
            File.Delete(@"C:\Users\user\Desktop\pp2_!\week 2\Task 4\input1.txt");


        }
    }
}
