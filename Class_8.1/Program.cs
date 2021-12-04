using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Class_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\BIM обучение");
            Console.WriteLine("Название каталога: {0} ", @"D:\BIM обучение");
            foreach (var item in directory.GetDirectories())  /// foreach - цикл , с его помощью переберём папку и выведем название
            {
                Console.WriteLine("Название подкаталога: {0}", item.Name); /// Имя (подкаталога)
                foreach (var it in item.GetDirectories())
                    Console.WriteLine("Список файлов: {0}", it.Name);  /// содержимое папок (подкатологов)
                Console.WriteLine();
            }
            foreach (var item in directory.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}