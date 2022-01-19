using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples {
    internal class LazyEvaluation {
        public static void Run() {
            Console.WriteLine("Отложенное вычисление");
            var list = new List<int>() { 1, 2, 3, 4 };
            var odds = list.Where(x => x % 2 != 0);
            list.Add(5);
            Console.WriteLine(string.Join(", ", odds)); // 1, 3, 5
        }
    }
}
