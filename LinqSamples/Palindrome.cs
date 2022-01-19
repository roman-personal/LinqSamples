using System;
using System.Linq;

namespace LinqSamples {
    internal class Palindrome {
        public static void Run() {
            Console.WriteLine("ЭТО ПАЛИНДРОМ???");
            string text = "А роза упала на лапу Азора";
            Console.WriteLine(text);
            Console.WriteLine(IsPalindrome(text));
            text = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(text);
            Console.WriteLine(IsPalindrome(text));
        }

        public static bool IsPalindrome(string text) {
            if (string.IsNullOrEmpty(text))
                return true;
            var cleared = text
                .Where(ch => char.IsLetterOrDigit(ch))
                .Select(ch => char.ToUpper(ch));
            return cleared.SequenceEqual(cleared.Reverse());
        }
    }
}
