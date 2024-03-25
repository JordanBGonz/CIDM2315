using System;

class Program
{
   
    public static void Main(string[] args)
    {
   
        int[] int_array = { 11, 23, 31, 42, 53 };
        ArraySum(int_array);

        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        PrintAllOddNumber(array_2d);

        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach (int num in Q2_3)
        {
            Console.Write(num + " ");
        }
    }

    public static void ArraySum(int[] int_array)
    {
        int sum = 0;
        foreach (int num in int_array)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of int_array is: {sum}");
    }

    public static int ElementSum(int[,] array_2d)
    {
        int sum = 0;
        foreach (int num in array_2d)
        {
            sum += num;
        }
        return sum;
    }
  public static void PrintAllOddNumber(int[,] array_2d)
  {
      
      foreach (int num in array_2d)
      {
          if (num % 2 != 0)
          {
              Console.Write(num + " ");
          }
      }
  }
    
    public static int[,] DoubleArray(int[,] array_2d)
    {
        int rows = array_2d.GetLength(0);
        int cols = array_2d.GetLength(1);
        int[,] doubledArray = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                doubledArray[i, j] = array_2d[i, j] * 2;
            }
        }
        return doubledArray;
    }
}
