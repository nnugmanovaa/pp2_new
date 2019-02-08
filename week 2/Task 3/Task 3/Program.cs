using System;
using System.IO;
namespace Task_3
{
    class Program
    {
        public static void showspaces(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write(" ");
            }
        }
        public static void showDirectory(DirectoryInfo d, int level)
        {
            FileInfo[] fi = d.GetFiles();
            DirectoryInfo[] di = d.GetDirectories();

            foreach (FileInfo f in fi)
            {
                showspaces(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo directory in di)
            {
                showspaces(level);
                Console.WriteLine(directory.Name);
                showDirectory(directory, level + 1);

            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\user\Desktop");
            showDirectory(d, 0);
            Console.ReadKey();
        }
    }
}

