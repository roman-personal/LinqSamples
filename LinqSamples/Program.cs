using System;

namespace LinqSamples {
    internal class Program {
        static void Main(string[] args) {
            // Palindrome
            Console.WriteLine("ЭТО ПАЛИНДРОМ???");
            string text = "А роза упала на лапу Азора";
            Console.WriteLine(text);
            Console.WriteLine(Palindrome.IsPalindrom(text));
        }
    }
}
