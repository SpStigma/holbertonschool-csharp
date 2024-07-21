using System;

public class Queue<T>
{
    /// <summary>
    /// Get the type of the elements in the queue.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
