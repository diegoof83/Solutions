using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(IsValid("{"));
                //Console.WriteLine(IsValid("{{({})}}"));                
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }

        public static bool IsValid(string s)
        {
            //Open brackets must be closed by the same type of brackets.
            //Open brackets must be closed in the correct order.

            if (string.IsNullOrEmpty(s))
                throw new NullReferenceException("Null string can not be precessed!");
            //string consists of parentheses only?
            if (IsOnlyBrackets(s))
                throw new InvalidOperationException("The string must consists of parentheses only!");

            // Creates and initializes a new Stack.
            var myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            // Displays the properties and values of the Stack.
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:    {0}", myStack.Count);
            Console.Write("\tValues:");
            PrintValues(myStack);

            return true;
        }

        /// <summary>
        /// Verify regular expression for only parentheses/brackets '()[]{}'
        /// </summary>
        /// <param name="s">string to be compared</param>
        /// <returns>True if they match</returns>
        public static bool IsOnlyBrackets(string s)
        {
            var _regex = new Regex(@"[()[\]{}]+");
            return _regex.IsMatch(s);
        }

        public static void PrintValues(IEnumerable<string> myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
