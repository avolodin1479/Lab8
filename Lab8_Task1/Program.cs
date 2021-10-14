using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\BIM";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Подкаталоги:");
                string[] directories = Directory.GetDirectories(path);
                foreach (string d in directories)
                {
                    Console.WriteLine(d);
                }

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(path);
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }
            }

            Console.ReadKey();
        }
    }
}
