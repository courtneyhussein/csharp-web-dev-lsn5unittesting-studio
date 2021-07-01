using System;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(String str)
        {
            if (str == "")
            {
                throw new ArgumentException("Arguement must not be an empty string.");
            }
            bool hasBracket = false;
            int brackets = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (ch == '[')
                {
                    brackets++;
                    hasBracket = true;
                }
                else if (ch == ']')
                {
                    brackets--;
                    hasBracket = true;
                }
                //New if statement that returns false if a backwards bracket ever comes before a forwards bracket.
                if (brackets < 0)
                {
                    return brackets == 0;
                }
            }
            //If statement that checks to see if the string did not contain any brackets at all.
            if (hasBracket == false)
            {
                return hasBracket;
            }
            return brackets == 0;
        }
    }
}
