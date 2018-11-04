using System;
using System.Collections.Generic;

namespace Day18QueuesAndStacks
{
    class Solution
    {
        private Stack<char> stack;
        private Queue<char> queue;

        public Solution()
        {
            stack = new Stack<char>();
            queue = new Queue<char>();
        }

        public void pushCharacter(char ch)
        {
            stack.Push(ch);
        }

        public char popCharacter()
        {
            return stack.Pop();
        }

        public void enqueueCharacter(char ch)
        {
            queue.Enqueue(ch);
        }

        public char dequeueCharacter()
        {
            return queue.Dequeue();
        }


        static void Main(string[] args)
        {
            // read the string s
            string s = Console.ReadLine();

            Solution obj = new Solution();

            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            for (int i= 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("The word, {0} is palindrome.", s);
            } else
            {
                Console.WriteLine("The word, {0} is not palindrome.", s);
            }

        }
    }
}
