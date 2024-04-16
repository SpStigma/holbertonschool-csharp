using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        if (aStack.Count == 0 || aStack == null)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        if (aStack.Contains(search))
        {
            Console.WriteLine($"Stack contains \"{search}\": {true}");
            while (aStack.Pop() != search)
            {
            }
        }
        else if (!aStack.Contains(search))
        {
            Console.WriteLine($"Stack contains \"{search}\": {false}");
        }
        aStack.Push(newItem);
        return aStack;
    }
}