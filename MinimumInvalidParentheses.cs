using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge1
{
    public class MinimumInvalidParentheses
    {
        public static string[] RemoveMinimalParentheses(string s)
        {
            var dicRemoval = new Dictionary<int, HashSet<string>>();


            if (IsValid(s))
            {
                var validString = new string[] { s };
                return validString;
            }

            if(s.Length <= 2 && !IsValid(s))
            {
                var validString = new string[] { "" };
                return validString;

            }

            for(int i = 1; i < s.Length; i++)
            {
                for(int j = 0; j < s.Length; j++)
                {
                    string left = s.Substring(0, j);
                    string right = s.Substring(j + 1);

                    string newString = left + right;

                    if (IsValid(newString))
                    {
                        if (dicRemoval.ContainsKey(i))
                        {
                            var set = dicRemoval[i];
                            set.Add(newString);
                            dicRemoval[i] = set;
                        }
                        else
                        {
                            var set = new HashSet<string>();
                            set.Add(newString);
                            dicRemoval.Add(i, set);                           

                        }

                    }
                    

                    

                }

                if(dicRemoval.Count >= 1)
                {
                    break;
                }

            }

            var minimalRemovalList = dicRemoval.OrderBy(kvp => kvp.Key).First();

            return minimalRemovalList.Value.ToArray();
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
