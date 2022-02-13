using System;
using System.Collections;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputParentheses = "()";
            IsValid(inputParentheses);
        }

        static bool IsValid(string s)
        {
            Stack stack = new Stack();

            if (s.Length == 0 || s.Length < 2)
            {
                return false;
            }

            foreach (char c in s.ToCharArray())
            {
                if (stack.Count == 0)
                {
                    stack.Push(c);
                }
                else
                {
                    if (c == '(' || c == '{' || c == '[')
                    {
                        stack.Push(c);
                    }
                    else if (c == ')' && (char)stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (c == '}' && (char)stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else if (c == ']' && (char)stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }                
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
