using System;

class Program
{
    static void Main()
    {
        // 1. Define a sample square matrix
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int n = matrix.GetLength(0); // Gets the size of the matrix (3x3)
        int primarySum = 0;
        int secondarySum = 0;

        // 2. Calculate the sums using a single loop
        for (int i = 0; i < n; i++)
        {
            primarySum += matrix[i, i];            // Top-left to bottom-right
            secondarySum += matrix[i, n - i - 1];  // Top-right to bottom-left
        }

        // 3. Print the results
        Console.WriteLine($"Primary Diagonal Sum: {primarySum}");      // 1 + 5 + 9 = 15
        Console.WriteLine($"Secondary Diagonal Sum: {secondarySum}");  // 3 + 5 + 7 = 15
        Console.WriteLine($"Total Combined Sum: {primarySum + secondarySum}");
    }
}
