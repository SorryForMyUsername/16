using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    /// <summary>
    /// Задача 1. Объявление списка массивов, добавление элементов в массив, вывод элементов списка массива.
    /// </summary>
    internal class Program
    {
        static void OutputArrayList(ArrayList list)
        {
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
        }

        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            a1.Add(1);
            a1.Add("Example");
            a1.Add(true);

            OutputArrayList(a1);

            Console.ReadKey(true);
        }
    }
}
