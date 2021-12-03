using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array_completed;
        int i = 0;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        
        array_completed = new int[size];
        if (size == 0)
        {
            Console.Write("\n");
            return (array_completed);
        }

        while (i < size)
        {
            array_completed[i] = i;
            Console.Write("{0}{1}", i, i == size - 1 ? "\n" : " ");
            i++;
        }
        return (array_completed);
    }
}
