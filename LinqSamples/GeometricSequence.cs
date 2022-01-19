using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples {
    internal class GeometricSequence {
        public static void Run() {
            Console.WriteLine("Генератор последовательности");
            var query = Sequence(1, 2).Take(16);
            Console.WriteLine(string.Join(", ", query));
        }

        static IEnumerable<int> Sequence(int start, int ratio) {
            while (true) {
                yield return start;
                start *= ratio;
            }
        }
    }
}
