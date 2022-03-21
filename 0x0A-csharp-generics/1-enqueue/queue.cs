using System;

/// <summary>
/// This is Queue.
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// This is Queue empty class.
    /// </summary>
    public Type CheckType()
    {
        return(typeof(T));
    }

    /// <summary>
    /// This is Queue empty class.
    /// </summary>
    public class Node
    {
        /// <summary>This is Queue empty class.</summary>
        public T value = default(T);
        /// <summary>This is Queue empty class.</summary>
        public Node next = null;

        /// <summary>This is Queue empty class.</summary>
        public Node(T var)
        {
            value = var;
        }
    }

    /// <summary>This is Queue empty class.</summary>
    public Node head = null;
    /// <summary>This is Queue empty class.</summary>
    public Node tail = null;
    /// <summary>This is Queue empty class.</summary>
    public int count;

    /// <summary>This is Queue empty class.</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>This is Queue empty class.</summary>
    public int Count()
    {
        return(count);
    }
}
