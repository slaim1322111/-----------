using System;

public class ArrayManipulator
{
    private int[] a;

    public ArrayManipulator(int[] array)
    {
        this.a = array;
    }

    public int this[int b]
    {
        get { return a[b]; }
        set { a[b] = value; }
    }

    public void MoveMinToEnd()
    {
        int b = 0;
        int c = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < c)
            {
                b = i;
                c = a[i];
            }
        }

        for (int i = b; i < a.Length - 1; i++)
        {
            a[i] = a[i + 1];
        }

        a[a.Length - 1] = c;
    }

    public void DisplayArray()
    {
        foreach (var c in a)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 4, 2, 1, 5, 3 };
        ArrayManipulator manipulator = new ArrayManipulator(numbers);

        manipulator.DisplayArray();

        manipulator.MoveMinToEnd();

        manipulator.DisplayArray();
    }
}
