﻿using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    //Write your code here
    public Stack<char> iStack = new Stack<char>()    ;
    public Queue<char> iQueue = new Queue<char>();
   //LinkedList<char> iQueue = new LinkedList<char>();

    private void pushCharacter(char c)
    {
        iStack.Push(c);
    }

    private void enqueueCharacter(char c)
    {
        iQueue.Enqueue(c);
    }
    private char popCharacter()
    {
        char iPopped = iStack.Pop();
        return iPopped;
    }
    private char dequeueCharacter()
    {
        char iDequeued = iQueue.Dequeue();
        return iDequeued;
    }


    static void Main(String[] args)
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object p.
        Solution obj = new Solution();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            var a = obj.popCharacter();
            var b = obj.dequeueCharacter();
            if (a != b )
            // if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }


}