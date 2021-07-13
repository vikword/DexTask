using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexTask
{
    class CustomType
    {
        public string Lines { get; private set; }
        public int Numbers { get; private set; }
        public DateTime DateTime { get; private set; }
        public bool BoolFlag { get; private set; }

        private static readonly Random rand = new Random();

        public override string ToString()
        {
            return $"Строка: {Lines}\tЧисло: {Numbers}\tДата: {DateTime}\tBool: {BoolFlag}";
        }

        public static CustomType GeneratingObjects()
        {
            bool flag = false;
            if (rand.Next(0, 100) % 2 == 0)
            {
                flag = true;
            }
            return new CustomType()
            {
                Lines = Guid.NewGuid().ToString("n").Substring(0, 8),
                Numbers = rand.Next(100, 130),
                DateTime = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(rand.Next(1000000000, 1999999999)),
                BoolFlag = flag
            };
        }
    }
}
