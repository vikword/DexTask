using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexTask
{
    class Program
    {
        static void Main()
        {
            CustomType[] obj = new CustomType[100];
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] = CustomType.GeneratingObjects();
            }

            var WhereOrder = obj.Where(n => n.BoolFlag == true && n.Lines[0] == 'c')
                                .OrderBy(u => u.Numbers);
            foreach (var n in WhereOrder)
            {
                Console.WriteLine(n);
            }

            var group = obj.GroupBy(c => c.BoolFlag);
            foreach (var c in group)
            {
                Console.WriteLine($"{c.Key} - количество: {c.Count()}\n");
            }

            var all = obj.All(s => s.Numbers > 99);
            Console.WriteLine($"Все элементы коллекции obj.Numbers больше: 127 - {all}\n");

            var any = obj.Any(u => u.Numbers > 140);
            Console.WriteLine($"Есть элемент в коллекции obj.Numbers больше: 140 - {any}\n");

            var sum = obj.Sum(s => s.Numbers);
            Console.WriteLine($"Сумма чисел obj.Numbers {sum}\n");

            var min = obj.Min(s => s.Numbers);
            Console.WriteLine($"Минимальное значение obj.Numbers {min}\n");

            var max = obj.Max(s => s.Numbers);
            Console.WriteLine($"Максимальное значение obj.Numbers {max}\n");
            Console.ReadKey();
        }
    }
}
