using System;

public class Program
{
    public static void ReplaceNegativeWithAbsolute(ref int[] array, out int m)
    {
        m = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = -array[i];
                m++;
            }
        }
    }

    public static void Main()
    {
        int[] n = { 1, -2, -3, -4, 5, -6, -7, -8, -9, -10 };

        PrintArray(n);

        int a;
        ReplaceNegativeWithAbsolute(ref n, out a);

     
        PrintArray(n);

        Console.WriteLine(a);
    }

    public static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item+ " ");
        }
        Console.WriteLine();
    }
}
