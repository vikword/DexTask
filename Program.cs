using System;
using System.Linq;

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

            var whereOrder = obj.Where(n => n.BoolFlag && n.Lines[0] == 'c')
                                .OrderBy(u => u.Numbers);
            foreach (var n in whereOrder)
            {
                Console.WriteLine(n);
            }

            var group = obj.GroupBy(c => c.BoolFlag);
            foreach (var c in group)
            {
                Console.WriteLine($"{c.Key} - количество: {c.Count()}\n");
                foreach (var item in c)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            DateTime time = new DateTime(1970, 1, 1, 0, 0, 0);
            var all = obj.All(s => s.DateTime > time);
            Console.WriteLine($"Все элементы коллекции s.DateTame больше: {time} - {all}\n");

            var any = obj.Any(u => u.Lines == "4f896b01");
            Console.WriteLine($"Элемент в коллекции u.Lines равен: 4f896b01 - {any}\n");

            var sum = obj.Sum(s => s.Numbers);
            Console.WriteLine($"Сумма чисел s.Numbers {sum}\n");

            var min = obj.Min(s => s.BoolFlag);
            Console.WriteLine($"Минимальное значение s.BoolFlag {min}\n");

            var max = obj.Max(s => s.DateTime);
            Console.WriteLine($"Максимальное значение s.DateTime {max}\n");
            Console.ReadKey();
        }
    }
}