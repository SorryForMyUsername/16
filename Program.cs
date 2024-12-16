using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    /// <summary>
    /// Залача 2. Количество элементво списка, проверка наличия элемента в коллекции ArrayList, 
    /// удаление элемента в определённой позиции коллекции ArrayList.
    /// </summary>
    internal class Program
    {
        static void OutputArrayList(ArrayList list, string name)
        {
            Console.WriteLine($"Элементы списка {name}:");
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();

            a1.Add(1);
            a1.Add("Example");
            a1.Add(true);

            Console.WriteLine($"Размер списка: {a1.Count}");

            Console.WriteLine($"Содержит ли список а1 элемент 2? {a1.Contains(2)}\n");

            OutputArrayList(a1, "a1");
            a1.RemoveAt(1);
            OutputArrayList(a1, "a1");

            Console.ReadKey(true);
        }
    }
}
