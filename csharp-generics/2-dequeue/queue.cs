using System;

/// <summary>
/// Represents a queue of elements of type T.
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value stored in the node.
        /// </summary>
        public T value { get; set; }

        /// <summary>
        /// Gets or sets the reference to the next node in the queue.
        /// </summary>
        public Node next { get; set; }

        /// <summary>
        /// Initializes a new instance of the Node class with a specified value.
        /// </summary>
        /// <param name="value">The value to be stored in the node.</param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>
    /// Gets or sets the head node of the queue.
    /// </summary>
    public Node head { get; private set; }

    /// <summary>
    /// Gets or sets the tail node of the queue.
    /// </summary>
    public Node tail { get; private set; }

    /// <summary>
    /// Gets the number of elements in the queue.
    /// </summary>
    public int count { get; private set; }

    /// <summary>
    /// Initializes a new instance of the Queue class.
    /// </summary>
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="value">The value to be added to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (tail != null)
        {
            tail.next = newNode;
        }
        tail = newNode;

        if (head == null)
        {
            head = newNode;
        }

        count++;
    }

    /// <summary>
    /// Removes and returns the element at the front of the queue.
    /// </summary>
    /// <returns>The value of the removed element, or the default value of T if the queue is empty.</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;

        if (head == null)
        {
            tail = null;
        }

        count--;
        return value;
    }

    /// <summary>
    /// Gets the number of elements in the queue.
    /// </summary>
    /// <returns>The number of elements in the queue.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Gets the type of elements in the queue.
    /// </summary>
    /// <returns>The type of elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
