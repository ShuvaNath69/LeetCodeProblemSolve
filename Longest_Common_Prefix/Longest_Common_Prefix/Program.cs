using System;
using System.Linq;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[]{ "dog", "racecar", "car" };

            LongestCommonPrefix(strs);
        }

        static string LongestCommonPrefix(string[] strs)
        {
            var getLength = strs.Length;

            if (getLength == 0)
                return "";

            else if (getLength == 1)
                return strs[0];

            else
            {
                var createString = "";
                var sortedArray = strs.ToArray();
                Array.Sort(sortedArray);

                string firstString = sortedArray[0];
                string lastString = sortedArray[^1];  

                for (int i = 0; i < firstString.Length; i++)
                {
                    if (firstString[i] != lastString[i])
                    {
                        break;                 
                    }
                    else
                    {
                        createString += firstString[i];
                    }

                }
                return createString;
            }

            return "";
            
        }
    }
}
