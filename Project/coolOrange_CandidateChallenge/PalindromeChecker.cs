using System;

namespace coolOrange_CandidateChallenge
{
    public class PalindromeChecker
    {
        /// <summary>
        /// Recursively checks if the given string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check for palindrome property.</param>
        /// <returns>True if the string is a palindrome; otherwise, false.</returns>
        public static bool IsPalindrome(string s)
        {
            /*
             * Base case: If the string's length is 1 or 0, it is considered a palindrome.
             */
            if (s.Length <= 1)
            {
                return true;
            }

            /*
             * Recursively checks if the first and last characters of the string are equal.
             * If they are equal, it calls itself with the substring excluding the first and last characters.
             * This process continues until the length of the string becomes 0 or 1,
             * at which point the method returns true as all characters checked were equal,
             * or until the first and last characters are not equal, in which case it returns false.
             */
            else if (s[0] == s[s.Length - 1])
            {
                return IsPalindrome(s.Substring(1, s.Length - 2));
            }
            else
            {
                return false;
            }
        }

    }
}
