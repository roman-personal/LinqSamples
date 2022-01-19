using System;
using System.Linq;

namespace LinqSamples {
    internal class MixedSyntax {
        public static void Run() {
            Console.WriteLine("Cмешанный синтаксис");
            var values = Enumerable.Range(1, 10);
            int sumOfOdds = (from x in values 
                             where x % 2 != 0 
                             select x).Sum();
            Console.WriteLine($"Сумма нечетных чисел в диапазоне от 1 до 10 равна {sumOfOdds}");
        }
    }
}
