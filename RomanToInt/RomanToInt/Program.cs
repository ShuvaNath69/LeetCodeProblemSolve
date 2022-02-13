using System;
using System.Collections.Generic;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "III";
            RomanToInt(s);
        }

        static int RomanToInt(string s)
        {
            if (s == null)
            {
                return 0;

            }
            else
            {
                Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

                keyValuePairs.Add("I", 1);
                keyValuePairs.Add("V", 5);
                keyValuePairs.Add("X", 10);
                keyValuePairs.Add("L", 50);
                keyValuePairs.Add("C", 100);
                keyValuePairs.Add("D", 500);
                keyValuePairs.Add("M", 1000);

                char[] charArr = s.ToCharArray();

                int resultRomanToInt = 0;
                int storeTempValue = 0;

                for (int i = charArr.Length - 1; i >= 0; i--)
                {
                    var findIntValue = keyValuePairs[charArr[i].ToString()];

                    if (findIntValue >= storeTempValue)
                    {
                        resultRomanToInt += findIntValue;
                    }
                    else
                    {
                        resultRomanToInt -= findIntValue;
                    }

                    storeTempValue = findIntValue;
                }

                Console.WriteLine(resultRomanToInt);
            }
            return 0;
        }
    }
}
