using System;

namespace DexTask
{
    class CustomType
    {
        public string Lines { get; private set; }
        public int Numbers { get; private set; }
        public DateTime DateTime { get; private set; }
        public bool BoolFlag { get; private set; }

        private static readonly Random Rand = new Random();

        public override string ToString()
        {
            return $"Строка: {Lines}\tЧисло: {Numbers}\tДата: {DateTime}\tBool: {BoolFlag}";
        }

        public static CustomType GeneratingObjects()
        {
            var flag = Rand.Next(2) % 2 == 1;
            return new CustomType()
            {
                Lines = Guid.NewGuid().ToString("n").Substring(0, 8),
                Numbers = Rand.Next(100, 130),
                DateTime = new DateTime(1990, 1, 1, 0, 0, 0, 0).AddSeconds(Rand.Next(0, 1999999999)),
                BoolFlag = flag
            };
        }
    }
}
