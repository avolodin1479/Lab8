using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Text_Task2.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            int[] a = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = random.Next(-50, 50);
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("{0}", a[i]);
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                int sum = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    int b = Convert.ToInt32(line);
                    sum = sum + b;
                }
                Console.WriteLine("Сумма чисел: ");
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }

    }
}
