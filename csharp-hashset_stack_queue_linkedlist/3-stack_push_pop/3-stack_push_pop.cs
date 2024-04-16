using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print number of items
        Console.WriteLine("Number of items: " + aStack.Count);

        // Print top item
        if (aStack.Count > 0)
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        // Check if stack contains search
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"" + search + "\": " + containsSearch);

        // Remove items up to search if it exists
        Stack<string> tempStack = new Stack<string>();
        while (aStack.Count > 0 && aStack.Peek() != search)
        {
            tempStack.Push(aStack.Pop());
        }
        
        // Pop the search item if it was found
        if (aStack.Count > 0 && aStack.Peek() == search)
        {
            aStack.Pop();
        }

        // Add new item
        aStack.Push(newItem);

        // Push back the items in tempStack
        while (tempStack.Count > 0)
        {
            aStack.Push(tempStack.Pop());
        }

        return aStack;
    }
}
