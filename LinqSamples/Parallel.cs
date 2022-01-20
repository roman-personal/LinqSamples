using System;
using System.Diagnostics;
using System.Linq;

namespace LinqSamples {
    internal class Parallel {
        public static void Run() {
            Console.WriteLine("Sequential vs parallel LINQ");
            var sw = new Stopwatch();
            // Генерируем кучу данных
            Console.WriteLine("Generating...");
            sw.Start();
            var data = GenerateData(500000000); // 500M values ~ 2GB
            sw.Stop();
            Console.WriteLine($"Done! Elapsed: {sw.Elapsed}");
            // Ищем максимум последовательным LINQ
            Console.WriteLine("GetMaxSequential...");
            sw.Restart();
            float maxval = GetMaxSequential(data);
            sw.Stop();
            Console.WriteLine($"Done! Max: {maxval}, Elapsed: {sw.Elapsed}");
            // Ищем максимум параллельным LINQ
            Console.WriteLine("GetMaxParallel...");
            sw.Restart();
            maxval = GetMaxParallel(data);
            sw.Stop();
            Console.WriteLine($"Done! Max: {maxval}, Elapsed: {sw.Elapsed}");
        }

        static float GetMaxSequential(float[] data) =>
            data.Max();

        static float GetMaxParallel(float[] data) =>
            data.AsParallel()
                //.WithDegreeOfParallelism(4) // try this!!!
                .Max();

        static float[] GenerateData(int count) {
            var random = new Random();
            var result = new float[count];
            for (int i = 0; i < count; i++)
                result[i] = (float)(random.NextDouble() * 1000);
            return result;
        }
    }
}
