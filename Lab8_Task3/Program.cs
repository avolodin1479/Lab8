using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Text for Task3\Text3.txt";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                Console.WriteLine("Количество символов в тексте: {0}", sr.ReadToEnd().Length);
            }

            using (StreamReader sr2 = new StreamReader(path, Encoding.Default))
            {
                string[] words = sr2.ReadToEnd().Split(new char[] { ' ' });
                Console.WriteLine("Количество слов в тексте: {0}", words.Length);
            }

            using (StreamReader sr3 = new StreamReader(path, Encoding.Default))
            {
                string[] strings = sr3.ReadToEnd().Split(new char[] { '\n' });
                Console.WriteLine("Количество строк в тексте: {0}", strings.Length);
            }

            Console.ReadKey();
        }
    }
}
