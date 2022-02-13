using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int palindroneNumber = -2147483412;

            IsPalindrome(palindroneNumber);
            RevereseInteger(palindroneNumber);
        }
 
        static void IsPalindrome(int palindroneNumber)
        {
            int storeNumber = palindroneNumber;

            int ReverseNumber = 0;

            while (storeNumber > 0)
            {
                int remainder = storeNumber % 10;

                ReverseNumber = (ReverseNumber * 10) + remainder;

                storeNumber = storeNumber / 10;
            }

            Console.WriteLine(ReverseNumber);

            if (palindroneNumber == ReverseNumber)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            Console.ReadLine();
        }

        static void RevereseInteger(int palindroneNumber)
        {
            if (palindroneNumber < int.MinValue || palindroneNumber > int.MaxValue)
                Console.WriteLine("0");

            string testCase = palindroneNumber < 0 ? (palindroneNumber * (-1)).ToString() : palindroneNumber.ToString();

            string resStr = "";

            int res = 0;

            for (int i = testCase.Length - 1; i >= 0; i--)
            {
                resStr += testCase[i];
            }

            bool t = int.TryParse(resStr, out res);

            res = palindroneNumber < 0 ? res * (-1) : res;

            Console.WriteLine(res);
        }
    }
}
