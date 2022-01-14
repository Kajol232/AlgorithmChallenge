using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge1
{
    public class ValidSubstring
    {
        public static int CheckLongest(string s)
        {
            int max = 0;
            for(int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j <= s.Length - i; j++)
                {
                    int len = j + i - 1;
                    String newString = "";
                    for (int k = j; k <= len; k++)
                    {
                        newString += s[k];

                    }

                    if (IsValid(newString))
                    {
                        if (newString.Length > max)
                        {
                            max = newString.Length;
                        }
                    }


                }
                
            }

            return max;
        }

        private static bool IsValid(string code)
        {
            bool isValid = false;
            Stack<char> charStack = new Stack<char>();
            foreach (var c in code)
            {
                if (c.Equals('('))
                {
                    charStack.Push(c);
                }

                if (c.Equals(')'))
                {
                    if (charStack.Count > 0)
                    {
                        charStack.Pop();
                    }
                    else
                    {
                        return isValid;
                    }

                }

            }

            if (charStack.Count == 0)
            {
                isValid = true;
            }

            return isValid;

        }
    }
}

