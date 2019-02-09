using System;
using System.IO;
namespace Task_3
{
    class Program
    {
        public static void showspaces(int level)//n times space for sub directories
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write(" ");
            }
        }
        public static void showDirectory(DirectoryInfo d, int level)
        {
            FileInfo[] fi = d.GetFiles();//collect files in directory in array  
            DirectoryInfo[] di = d.GetDirectories();//collect subdirectories in array

            foreach (FileInfo f in fi) //at first out all files in directory
            {
                showspaces(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo directory in di) //then out all subdirectories
            {
                showspaces(level);
                Console.WriteLine(directory.Name);
                showDirectory(directory, level + 1);

            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\user\Desktop");////string path of directory
            showDirectory(d, 0);//call recursive function to operate
            Console.ReadKey();
        }
    }
}

