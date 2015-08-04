using System;
/*Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
and prints a matrix like in the examples below. Use two nested loops.
 */ 

class MatrixOfNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num > 0 && num < 21)
        {
            Console.Clear();
            int[,] matrix = new int[num, num];
            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    if (row > 0)
                    {
                        matrix[row, col] = matrix[row - 1, col] + 1;
                    }
                    else
                    {
                        matrix[row, col] = col + 1;
                    }
                    Console.SetCursorPosition(row * 3, col * 2);
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}
