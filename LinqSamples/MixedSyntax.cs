using System;
using System.Linq;

namespace LinqSamples {
    internal class MixedSyntax {
        public static void Run() {
            Console.WriteLine("Mixed syntax");
            var values = Enumerable.Range(1, 10);
            int sumOfOdds = (from x in values 
                             where x % 2 != 0 
                             select x).Sum();
            Console.WriteLine($"Sum of odds in range 1...10 is {sumOfOdds}");
        }
    }
}
