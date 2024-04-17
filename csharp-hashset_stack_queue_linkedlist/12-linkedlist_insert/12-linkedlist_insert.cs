using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (myLList.First == null || n <= myLList.First.Value)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }

        LinkedListNode<int> current = myLList.First;
        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }
        
        myLList.AddAfter(current, newNode);
        return newNode;
    }
}
