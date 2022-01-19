using System;
using System.Linq;

namespace LinqSamples {
    internal class Palindrome {
        public static bool IsPalindrom(string text) {
            if (string.IsNullOrEmpty(text))
                return true;
            var cleared = text
                .Where(ch => char.IsLetterOrDigit(ch))
                .Select(ch => char.ToUpper(ch));
            return cleared.SequenceEqual(cleared.Reverse());
        }
    }
}
