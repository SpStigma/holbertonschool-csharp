using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // Check if n is valid
        if (n < 0 ||n >= myLList.Count)
        {
            return 0;
        }
        //initialise a new node who will take the same value as our linkedList
        LinkedListNode<int> currentNode = myLList.First;
        //go through our linked list and update our CurrentNode
        for (int i = 0; i < n; i++)
        {
            currentNode = currentNode.Next;
        }
        return currentNode.Value;
    }
}
