using System;
using System.Linq;

namespace LinqSamples {
    internal class Palindrome {
        public static void Run() {
            Console.WriteLine("ЭТО ПАЛИНДРОМ???");
            string text = "А роза упала на лапу Азора";
            Console.WriteLine(text);
            Console.WriteLine(IsPalindrome(text));
            Console.WriteLine(IsPalindrome2(text));
            text = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(text);
            Console.WriteLine(IsPalindrome(text));
            Console.WriteLine(IsPalindrome2(text));
        }

        static bool IsPalindrome(string text) {
            if (string.IsNullOrEmpty(text))
                return true;
            var cleared = text
                .Where(ch => char.IsLetterOrDigit(ch))
                .Select(ch => char.ToUpper(ch));
            return cleared.SequenceEqual(cleared.Reverse());
        }

        static bool IsPalindrome2(string text) {
            if (string.IsNullOrEmpty(text))
                return true;
            int start = 0;
            int end = text.Length - 1;
            while (start < end) {
                if (!char.IsLetterOrDigit(text[start]))
                    start++;
                else if (!char.IsLetterOrDigit(text[end]))
                    end--;
                else if (char.ToUpper(text[start++]) != char.ToUpper(text[end--]))
                    return false;
            }
            return true;
        }
    }
}
