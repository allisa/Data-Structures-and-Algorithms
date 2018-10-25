using Stack_and_Queue.Classes;
using System;

namespace Multi_Bracket_Validation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string test1 = "(Hello World!)"; //true
            string test2 = "((){}[])"; //true
            string test3 = "(({}{})"; //false
            string test4 = "[{()}]"; //true
            string test5 = ""; //true

            Console.WriteLine(test1 + MultiBracketValidation(test1));
            Console.WriteLine(test2 + MultiBracketValidation(test2));
            Console.WriteLine(test3 + MultiBracketValidation(test3));
            Console.WriteLine(test4 + MultiBracketValidation(test4));
            Console.WriteLine(test5 + MultiBracketValidation(test5));

        }

        /// <summary>
        /// Method to check for matching open and closing brackets. Returns true if balanced, false if unbalanced
        /// </summary>
        /// <param name="input"></param>
        /// <returns>boolean</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack stack = new Stack(null);

            if (input.Length == 0)
                return true;

            for (int i = 0; i < input.Length; i++)
            {
                char currentCharacter = input[i];

                if (currentCharacter == '{' || currentCharacter == '[' || currentCharacter == '(')
                {
                    stack.Push(new Node(currentCharacter));
                }

                else if (currentCharacter == '}' || currentCharacter == ']' || currentCharacter == ')')
                {
                    switch (currentCharacter)
                    {
                        case '}':
                            if ((char)stack.Pop().Value != '{')
                                return false;
                            break;
                        case ']':
                            if ((char)stack.Pop().Value != '[')
                                return false;
                            break;
                        case ')':
                            if ((char)stack.Pop().Value != '(')
                                return false;
                            break;
                    }
                }
            }
            if (stack.Peek() != null)
            {
                return false;
            }
            return true;
        }
    }
}
