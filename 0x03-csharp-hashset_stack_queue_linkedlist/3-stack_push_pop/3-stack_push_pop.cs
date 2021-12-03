using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        bool true_false = aStack.Contains(search);

        Console.WriteLine("Number of items: {0}", aStack.Count); // Print the number of items in aStack

        if (aStack.Count <= 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: {0}", aStack.Peek()); //Print the item at the top of aStack without removing it
        }

        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains \"{0}\": {1}", search, true_false); //Print if aStack contains a given item search
            while (aStack.Contains(search))
            {
                aStack.Pop(); // remove all items up to and including search
            }
        }
        else
        {
            Console.WriteLine("Stack contains \"{0}\": {1}", search, true_false);
        }
        aStack.Push(newItem); // Add a new given item newItem to aStack
        return (aStack);
    }
}
