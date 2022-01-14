using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge1
{
    public class LongestDuplicatedString
    {
        public static string LongestDuplicated(string s)
        {
            var allSubstring = new Dictionary<string, int>();

            string longest = "";

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j <= s.Length - i; j++)
                {
                    int len = j + i - 1;
                    String newString = "";
                    for (int k = j; k <= len; k++)
                    {
                        newString += s[k];

                    }

                    AddToDictionary(allSubstring, newString);


                }
            }

            foreach(KeyValuePair<string, int> kvp in allSubstring)
            {
                if(kvp.Value >= 2)
                {
                    if(kvp.Key.Length > longest.Length)
                    {
                        longest = kvp.Key;
                    }

                }
            }

                    return longest;
        }

        private static void AddToDictionary(Dictionary<string, int> dic, string s)
        {
            if (dic.ContainsKey(s))
            {
                dic[s]++;
            }
            else
            {
                dic.Add(s, 1);
            }
        }
    }
}
